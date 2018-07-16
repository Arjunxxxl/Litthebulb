using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowStars : MonoBehaviour {
	
	camera_movement cm;
	bool complete = false;

	level_timer lt;
	public int star;
	public GameObject[] lit_bulb;

	// Use this for initialization
	void Start () {
		cm = camera_movement.Instance;
		complete = false;
		lt = level_timer.Instance;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		complete = cm.pass_level_done_bool();
		if(complete){
		star = lt.passStars();
		if(star == 1){lit_bulb[0].SetActive(true);}
		if(star == 2){lit_bulb[0].SetActive(true); lit_bulb[1].SetActive(true);}
		if(star == 3){lit_bulb[0].SetActive(true); lit_bulb[1].SetActive(true); lit_bulb[2].SetActive(true);}
		
		}
	}

	
}
