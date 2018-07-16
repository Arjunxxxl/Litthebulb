﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_cap3_5 : MonoBehaviour {

	public GameObject capacitor1, capacitor2;
	public GameObject cappos1, cappos2;
	public bool cap1 = false, cap2 = false;
	public bool activateCapacior1 = false, activateCapacior2 = false;

	public bool lit_bulb1, lit_bulb2;

	change_rot cr;

	circuit3_5 c;
	cap_time ct;
	bool[] result;

	#region Singleton
	public static activate_cap3_5 Instance;
	void Awake()
	{
		Instance = this;	
	}
	#endregion

	// Use this for initialization
	void Start () {
		c = circuit3_5.Instance;
		cr = change_rot.Instance;
		ct =cap_time.Instance;
	}
	
	
	// Update is called once per frame
	void Update () {
		if(cr.pass_gameobject() == capacitor1){
		if(capacitor1.transform.position == cappos1.transform.position){cap1 = true;}else{cap1 = false;}
		}
		if(cr.pass_gameobject() == capacitor2){
		if(capacitor2.transform.position == cappos2.transform.position){cap2 = true;}else{cap2 = false;}
		}

		result = c.pass_bool1();

		if(result[0] && cap1 && (result[8] || result[10]) && result[5] && result[2]){
			activateCapacior1 = true;
		}
		if(result[1] && cap2 && (result[9] || result[10]) && result[5] && result[3]){
			activateCapacior2 = true;
		}

		passCapStatus();
		
		if(!result[0] || !cap1 || (!result[8] && result[10]) || !result[5] || !result[2] ) {
			if(activateCapacior1){
			StartCoroutine(cap_chargeTime("activateCapacior1"));
			}
		}
		if(!result[1] || !cap2 || (!result[9] && !result[10]) || !result[5] || !result[3]) {
			if(activateCapacior2){
			StartCoroutine(cap_chargeTime("activateCapacior2"));
			}
		}


		if(activateCapacior1 && !cap1 && result[4] && result[6])
		 {lit_bulb1 = true;}else{lit_bulb1 = false;}
		
		if(activateCapacior2 && !cap2 && result[4] && result[7])
		 {lit_bulb2 = true;}else{lit_bulb2 = false;}

	}


		IEnumerator cap_chargeTime(string b){
		yield return new WaitForSeconds(5.0f);
		if(b.Equals("activateCapacior1")){activateCapacior1 = false;}
		if(b.Equals("activateCapacior2")){activateCapacior2 = false;}
	}

	public bool[] pass_bool(){
		bool[] bl = {lit_bulb1, lit_bulb2};
		return bl;
	}

	public void passCapStatus()
	{	bool[] cap_status = {((!result[0] || !cap1 || (!result[8] && result[10]) || !result[5] || !result[2] ) && activateCapacior1),
							((!result[1] || !cap2 || (!result[9] && !result[10]) || !result[5] || !result[3]) && activateCapacior2)
							};
		ct.getCapStatus(cap_status);
	}

}
