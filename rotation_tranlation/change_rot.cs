using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class change_rot : MonoBehaviour {


	float range = 1000.0f;

	bool isRot;

	Quaternion target_rot;
	Quaternion final_rot;

	camera_movement cm;
	bool level_start ;

	GameObject o;

	#region Singleton
	public static change_rot Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion


	// Use this for initialization
	void Start () {
		cm = camera_movement.Instance;
		if(cm){
		level_start = cm.pass_start_anim_bool();
		}
	}
	
	// Update is called once per frame
	void Update () {
		change_rot_click();
	}

	void change_rot_click(){
		if(cm){
		level_start = cm.pass_start_anim_bool();
		if(level_start){return;}
		}
		//Debug.Log("efrgthsr");


		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		o = null;
		
		if(Input.GetMouseButtonDown(0)){
			if(Physics.Raycast(ray, out hit, range)){
				//if (!IsPointerOverUIObject())
                {	

					isRot = true;
					o = hit.collider.gameObject;
					
					//StartCoroutine(rotate_now(hit.collider.gameObject));
				}
			}
		}
	} 


	public bool set_rot_bool(){
		return isRot;
	}

	public string pass_name(){
		if(o==null){
			return "";
		}else{
		return o.name;
		}
	}

		public GameObject pass_gameobject(){
		if(o==null){
			return null;
		}else{
		return o;
		}
	}

	public void stop_rot_bool(){
			isRot = false;
	}


}
