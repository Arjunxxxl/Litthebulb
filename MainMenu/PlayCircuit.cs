using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCircuit : MonoBehaviour {

	public GameObject obj1, obj2;
	public bool b1,b2;
	bool lit;

	public Light l1,l2;
	float time;
	float lerp,lerp2;

	float y1,y2;

	// Use this for initialization
	void Start () {
		b1 = b2 = true;
		time = 8.0f;
		lerp = 0.0f;
		lerp2 = 0.0f;
		l1.intensity = 0.0f;
		l2.intensity = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		y1 = Mathf.Abs(obj1.transform.rotation.eulerAngles.y) ;
		y2 = Mathf.Abs(obj1.transform.rotation.eulerAngles.y) ;
		if(y1 < 0.001f && y1 > -0.001f){y1 =0f;} if(y1 < 90.001f && y1 > 89.999f){y1 =90f;} if(y1 < 180.001f && y1 > 179.999f){y1 =180f;}
		if(y1 < 270.001f && y1 > 269.999f){y1 =270f;} if(y1 < 360.001f && y1 > 359.999f){y1 =0f;}

		if(y2 < 0.001f && y2 > -0.001f){y2 =0f;} if(y2 < 90.001f && y2 > 89.999f){y2 =90f;} if(y2 < 180.001f && y2 > 179.999f){y2 =180f;}
		if(y2 < 270.001f && y2 > 269.999f){y2 =270f;} if(y2 < 360.001f && y2 > 359.999f){y2 =0f;}

		if(y1 == 0f || y1 == 180.0f){b1 = true;}else{b1 = false;}
		if(y2 == 0f){b2 = true;}else{b2 = false;}

		lit = b1 && b2;
		glow();
	}

	void glow()
	{
		if(lit){
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
	}


}
