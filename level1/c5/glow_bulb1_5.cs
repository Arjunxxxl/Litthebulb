using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glow_bulb1_5 : MonoBehaviour {

	circuit1_5 c1;
	public bool lit1;
	public Light l1,l2;
	float time;
	float lerp,lerp2;

	camera_movement cm;

	// Use this for initialization
	void Start () {
		c1 = circuit1_5.Instance;
		lit1 = c1.pass_bool();
		time = 8.0f;
		lerp = 0.0f;
		lerp2 = 0.0f;
		l1.intensity = 0.0f;
		l2.intensity = 0.0f;

		cm = camera_movement.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		lit1 = c1.pass_bool();
		
		if(lit1){
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

		if(lit1){cm.level_done(true);}
	}	
	
}
