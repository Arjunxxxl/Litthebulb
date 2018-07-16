using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apply_rotation : MonoBehaviour {

	public bool rot = false;
	change_rot cr;

	Quaternion target_rot;
	Quaternion final_rot;

	GameObject obj_toRotate;
	GameObject obj_name;

	float r;
	int f_y;


	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
		//target_rot = final_rot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		rot = cr.set_rot_bool() ;
		obj_name = cr.pass_gameobject();
		if(obj_name == null){
			return;
		}

		if(obj_name.tag == "cap"){return;}

		obj_toRotate = obj_name;


		//clamp_rot();

		target_rot = obj_toRotate.transform.rotation;
		if(rot){
				final_rot = Quaternion.Euler(0,90,0)*target_rot;	
				
		}
				obj_toRotate.transform.rotation =  Quaternion.Slerp(target_rot, final_rot, 90.0f);
				stop_rot();
		
	}

	void stop_rot(){
		cr.stop_rot_bool();
	}

	void clamp_rot(){
		r= obj_toRotate.transform.eulerAngles.y;
		//Debug.Log(r);
		if(r == 90f || r== -270f || r == 180f || r == 0f || r == -90f){
			return;
		}else{
			f_y= (int)obj_toRotate.transform.eulerAngles.y;
		if(r<20.0f&&r>-20.0f){
					f_y = 0;
				} else if(r>70.0f && r<110.0f){
					f_y = 90;
				} else if(r>150.0f && r< 200.0f){
					f_y = 180;
				} else if(r>250.0f && r<290.0f){
					f_y = 270;
				} 
				else if(r>-100.0f && r<-80.0f){
					f_y = -90;
				} 
				 else if(r>350.0f && r<370.0f){
					f_y = 0;
				}
		obj_toRotate.transform.rotation = Quaternion.Euler(0,f_y,0);	
		}
	
	}


}
