using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_machine1 : MonoBehaviour {

	public float rot_speed;
	float t = 0;
	
	private void Awake() {
		Time.timeScale = 1.0f;
	}

	// Use this for initialization
	void Start () {
		 t= Time.deltaTime;
		 Time.timeScale = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate(rot_speed*t*Vector3.up, Space.World);
	}
}
