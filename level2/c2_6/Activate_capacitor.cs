using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_capacitor : MonoBehaviour {

	public GameObject capacitor1,capacitor2,capacitor3,capacitor4;
	public GameObject cappos1,cappos2,cappos3,cappos4;
	public bool cap1 = false,cap2=false,cap3 = false, cap4 = false;
	public bool activateCapacior1 = false,activateCapacior2 = false, activateCapacior3 = false, activateCapacior4 = false;

	public bool lit_bulb1 , lit_bulb2;

	change_rot cr;

	circuit2_6 c;
	cap_time ct;
	bool[] result;

	#region Singleton
	public static Activate_capacitor Instance;
	void Awake()
	{
		Instance = this;	
	}
	#endregion
	// Use this for initialization
	void Start () {
		c = circuit2_6.Instance;
		cr = change_rot.Instance;
		ct = cap_time.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		if(cr.pass_gameobject() == capacitor1){
			if(capacitor1.transform.position == cappos1.transform.position){cap1 = true;}else{cap1 = false;}
		}
		if(cr.pass_gameobject() == capacitor2){
			if(capacitor2.transform.position == cappos2.transform.position){cap2 = true;}else{cap2 = false;}
		}
		if(cr.pass_gameobject() == capacitor3){
			if(capacitor3.transform.position == cappos3.transform.position){cap3 = true;}else{cap3 = false;}
		}
		if(cr.pass_gameobject() == capacitor4){
			if(capacitor4.transform.position == cappos4.transform.position){cap4 = true;}else{cap4 = false;}
		}


		result = c.pass_bool1();

		if((result[9] && !result[4]) || result[10])
		{
			if(result[2] && result[1] && (result[6] || result[7]) ){
				if(cap1 ){
					activateCapacior1 = true;
				}
				if(cap3){
					activateCapacior3 = true;
				}
			}
		}

		if((result[11] && !result[5]) || result[12])
		{
			if(result[3] && result[1] && (result[6] || result[8]) ){
				if(cap2){
					activateCapacior2 = true;
				}
				if(cap3){
					activateCapacior4 = true;
				}
			}
		}

		 passCapStatus();

		if((result[9] && result[4]) || result[10] )
		{
			StartCoroutine(cap_chargeTime("activateCapacior1")); StartCoroutine(cap_chargeTime("activateCapacior2"));
			StartCoroutine(cap_chargeTime("activateCapacior3")); StartCoroutine(cap_chargeTime("activateCapacior4"));
		}
		if((result[11] && result[5]) || result[12])
		{
			StartCoroutine(cap_chargeTime("activateCapacior1")); StartCoroutine(cap_chargeTime("activateCapacior2"));
			StartCoroutine(cap_chargeTime("activateCapacior3")); StartCoroutine(cap_chargeTime("activateCapacior4"));
		}

		if(!result[1]){
			StartCoroutine(cap_chargeTime("activateCapacior1")); StartCoroutine(cap_chargeTime("activateCapacior2"));
			StartCoroutine(cap_chargeTime("activateCapacior3")); StartCoroutine(cap_chargeTime("activateCapacior4"));
		}

		if(!result[2] || !cap1 || !cap3){
			StartCoroutine(cap_chargeTime("activateCapacior1")); StartCoroutine(cap_chargeTime("activateCapacior3"));
		}
		if(!result[3] || !cap2 || !cap4){
			StartCoroutine(cap_chargeTime("activateCapacior2")); StartCoroutine(cap_chargeTime("activateCapacior4"));
		}

		if(activateCapacior1 && activateCapacior2 && result[0] && (!result[14] && !result[15] && !result[16] && !result[17] && !result[18])){
			lit_bulb1 = true;
		}else{
			lit_bulb1 = false;
		}

		if(activateCapacior3 && activateCapacior4 && result[13] && (!result[19] && !result[20] && !result[21] && !result[22] && !result[23]) ){
			lit_bulb2 = true;
		}else{
			lit_bulb2 = false;
		}


	}


	IEnumerator cap_chargeTime(string b){
		yield return new WaitForSeconds(5.0f);
		if(b.Equals("activateCapacior1")){activateCapacior1 = false;}
		if(b.Equals("activateCapacior2")){activateCapacior2 = false;}
		if(b.Equals("activateCapacior3")){activateCapacior3 = false;}
		if(b.Equals("activateCapacior4")){activateCapacior4 = false;}
	}

	public bool[] pass_bool(){
		bool[] bl = {lit_bulb1, lit_bulb2};
		return bl;
	}	

	public void passCapStatus()
	{	bool[] cap_status = {activateCapacior1 && (!result[2] || !cap1 || !cap3),
							activateCapacior2 && (!result[3] || !cap2 || !cap4),
							activateCapacior3 && (!result[2] || !cap1 || !cap3),
							activateCapacior4 && (!result[3] || !cap2 || !cap4),
							};
		ct.getCapStatus(cap_status);
	}
	

}
