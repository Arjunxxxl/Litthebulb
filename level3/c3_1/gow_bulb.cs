using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gow_bulb : MonoBehaviour {

	circuit3_1 c1;
	public bool[] lit;
	public Light l1,l2;
	float time;
	float lerp,lerp2;

	camera_movement cm;

	// Use this for initialization
	void Start () {
		c1 = circuit3_1.Instance;
		lit = c1.pass_bool1();
		time = 8.0f;
		lerp = 0.0f;
		lerp2 = 0.0f;
		l1.intensity = 0.0f;
		l2.intensity = 0.0f;

		cm = camera_movement.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		lit = c1.pass_bool1();

		
		if(lit[0] && lit[1] && lit[2]){
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

		if(lit[0]  && lit[1] && lit[2]){
			cm.level_done(true);
		}
	}
}
