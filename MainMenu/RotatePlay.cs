using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlay : MonoBehaviour {

	
	bool rot;
	Quaternion target_rot, final_rot;
	float y;

	// Use this for initialization
	void Start () {
		rot = true;
	}
	
	// Update is called once per frame
	void Update () {
		target_rot = transform.rotation;
		y = Mathf.Abs(transform.rotation.eulerAngles.y) ;
		if(y < 0.001f && y > -0.001f){y =0f;} if(y < 90.001f && y > 89.999f){y =90f;} if(y < 180.001f && y > 179.999f){y =180f;}
		if(y < 270.001f && y > 269.999f){y =270f;} if(y < 360.001f && y > 359.999f){y =0f;}
		
		if(rot && (y % 90f == 0f)){
				final_rot = Quaternion.Euler(0,90,0)*target_rot;	
		}
		transform.rotation = Quaternion.Lerp(target_rot, final_rot, 20.0f * Time.deltaTime);
		StartCoroutine(Rotate_now(rot));	
		
	}

	IEnumerator Rotate_now(bool b)
	{	
		yield return new WaitForSeconds(0.5f);
		
		rot = !b;
	}
}
