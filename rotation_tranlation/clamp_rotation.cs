using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clamp_rotation : MonoBehaviour {

	float r;
	int f_y;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//clamp_rot();
		
	}

	void clamp_rot(){
		r= transform.eulerAngles.y;
		//Debug.Log(r);
		if(r == 90f || r== -270f || r == 180f || r == 0f || r == -90f){
			return;
		}else{
			f_y= (int)transform.eulerAngles.y;
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
				} else if(r>350.0f && r<370.0f){
					f_y = 0;
				}
		transform.rotation = Quaternion.Euler(0,f_y,0);	
		}
	
	}

}
