﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glow_bulb3_4 : MonoBehaviour {

	activate_cap3_4 a1;
	public bool[] lit;
	public Light l1,l2,l3,l4;
	float time;
	float lerp,lerp2,lerp3,lerp4;

	camera_movement cm;

	// Use this for initialization
	void Start () {
		a1 = activate_cap3_4.Instance;
		lit = a1.pass_bool();
		time = 8.0f;
		lerp = 0.0f;
		lerp2 = 0.0f;
		l1.intensity = 0.0f;
		l2.intensity = 0.0f;

		lerp3 = 0.0f;
		lerp4 = 0.0f;
		l3.intensity = 0.0f;
		l4.intensity = 0.0f;

		cm = camera_movement.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		lit = a1.pass_bool();

		
		if(lit[0]){
			lerp += Time.deltaTime/time;
			l1.intensity = Mathf.Lerp(l1.intensity,15.0f,lerp);	 
			l2.intensity = Mathf.Lerp(l2.intensity,40.0f,lerp);
			lerp2 = 0.0f;
			
		}else{
			lerp2 += Time.deltaTime/time;
			l1.intensity = Mathf.Lerp(l1.intensity,0.0f,lerp2);	 
			l2.intensity = Mathf.Lerp(l2.intensity,0.0f,lerp2);
			lerp = 0.0f;
		}

		if(lit[1]){
			lerp3 += Time.deltaTime/time;
			l3.intensity = Mathf.Lerp(l3.intensity,15.0f,lerp3);	 
			l4.intensity = Mathf.Lerp(l4.intensity,40.0f,lerp3);
			lerp4 = 0.0f;
			
		}else{
			lerp4 += Time.deltaTime/time;
			l3.intensity = Mathf.Lerp(l3.intensity,0.0f,lerp4);	 
			l4.intensity = Mathf.Lerp(l4.intensity,0.0f,lerp4);
			lerp3 = 0.0f;
		}

		if(lit[0] && lit[1]){
			cm.level_done(true);
		}
	}
}