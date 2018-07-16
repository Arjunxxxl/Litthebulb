using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transtale_pos : MonoBehaviour {

	change_rot cr;
	GameObject click_obj;

	bool move1,move2;


	public GameObject[] capacitors_pos;

	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		click_obj = cr.pass_gameobject();
		
		transtate_obj(move1, move2);
		
		if(click_obj == null){return;}
		

		if(click_obj==gameObject){
			if(transform.position == capacitors_pos[0].transform.position){
				move1 = true;
				move2=false;
				}
			else if(transform.position == capacitors_pos[1].transform.position){
				move2 = true;
				move1 = false;
				}	
		}
		

	}

	void transtate_obj(bool a, bool b){
		if(a){
				transform.position = Vector3.Lerp(transform.position, capacitors_pos[1].transform.position, 35.0f*Time.deltaTime); 
		}else if(b){
				transform.position = Vector3.Lerp(transform.position, capacitors_pos[0].transform.position, 35.0f*Time.deltaTime); 
		}
	}

}
