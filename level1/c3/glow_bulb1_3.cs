using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glow_bulb1_3 : MonoBehaviour {

	circuit1_3 c1;
	public bool lit1;
	public Light l1,l2;
	public Light l3,l4;
	public Light l5,l6;
	float time;
	float lerp,lerp2;

	camera_movement cm;

	// Use this for initialization
	void Start () {
		c1 = circuit1_3.Instance;
		lit1 = c1.pass_bool1();
		time = 8.0f;
		lerp = 0.0f;
		lerp2 = 0.0f;
		l1.intensity = 0.0f;
		l2.intensity = 0.0f;
		l3.intensity = 0.0f;
		l4.intensity = 0.0f;
		l5.intensity = 0.0f;
		l6.intensity = 0.0f;

		cm = camera_movement.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		lit1 = c1.pass_bool1();
		
		if(lit1){
			lerp += Time.deltaTime/time;
			l1.intensity = Mathf.Lerp(l1.intensity,15.0f,lerp);	 
			l2.intensity = Mathf.Lerp(l2.intensity,40.0f,lerp);

			l3.intensity = Mathf.Lerp(l3.intensity,15.0f,lerp);	 
			l4.intensity = Mathf.Lerp(l4.intensity,40.0f,lerp);

			l5.intensity = Mathf.Lerp(l5.intensity,15.0f,lerp);	 
			l6.intensity = Mathf.Lerp(l6.intensity,40.0f,lerp);

			cm.level_done(true);

			lerp2 = 0.0f;
		}else{
			lerp2 += Time.deltaTime/time;
			l1.intensity = Mathf.Lerp(l1.intensity,0.0f,lerp2);	 
			l2.intensity = Mathf.Lerp(l2.intensity,0.0f,lerp2);

			l3.intensity = Mathf.Lerp(l3.intensity,0.0f,lerp2);	 
			l4.intensity = Mathf.Lerp(l4.intensity,0.0f,lerp2);

			l5.intensity = Mathf.Lerp(l5.intensity,0.0f,lerp2);	 
			l6.intensity = Mathf.Lerp(l6.intensity,0.0f,lerp2);

			lerp = 0.0f;
		}
	}
}
