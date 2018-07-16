using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glow_bulb1_10 : MonoBehaviour {

	circuit1_10 c1;
	public bool[] lit1;
	public Light l1,l2,l3,l4,l5,l6;
	float time;
	float lerp,lerp2,lerp3,lerp4,lerp5,lerp6;

	camera_movement cm;

	// Use this for initialization
	void Start () {
		c1 = circuit1_10.Instance;
		lit1 = c1.pass_bool();
		time = 8.0f;
		lerp = 0.0f;
		lerp2 = 0.0f;
		l1.intensity = 0.0f;
		l2.intensity = 0.0f;

		lerp3 = 0.0f;
		lerp4 = 0.0f;
		l3.intensity = 0.0f;
		l4.intensity = 0.0f;

		lerp5 = 0.0f;
		lerp6 = 0.0f;
		l5.intensity = 0.0f;
		l6.intensity = 0.0f;

		cm = camera_movement.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		lit1 = c1.pass_bool();
		
		if(lit1[0]){
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

		if(lit1[1]){
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


		if(lit1[2]){
			lerp5 += Time.deltaTime/time;
			l5.intensity = Mathf.Lerp(l5.intensity,15.0f,lerp5);	 
			l6.intensity = Mathf.Lerp(l6.intensity,40.0f,lerp5);
			lerp6 = 0.0f;
		}else{
			lerp6 += Time.deltaTime/time;
			l5.intensity = Mathf.Lerp(l5.intensity,0.0f,lerp6);	 
			l6.intensity = Mathf.Lerp(l6.intensity,0.0f,lerp6);
			lerp5 = 0.0f;
		}

		if(lit1[0]&&lit1[1]&&lit1[2]){cm.level_done(true);}



	}	
}
