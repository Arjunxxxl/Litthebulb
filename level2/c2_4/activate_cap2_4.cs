using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_cap2_4 : MonoBehaviour {

	public GameObject capacitor1,capacitor2;
	public GameObject cappos1,cappos2;
	public bool cap1 = false,cap2=false;
	public bool activateCapacior1 = false,activateCapacior2;

	public bool lit_bulb1 ;

	change_rot cr;

	circuit2_4 c;
	bool[] result;

	cap_time ct;

	#region Singleton
	public static activate_cap2_4 Instance;
	void Awake()
	{
		Instance = this;	
	}
	#endregion
	// Use this for initialization
	void Start () {
		c = circuit2_4.Instance;
		cr = change_rot.Instance;
		ct=cap_time.Instance;
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

		if(result[0] && cap1){
				activateCapacior1 = true;
				
		} else if(result[1] && cap2 && activateCapacior1){
			activateCapacior2 = true;
			
		}

		passCapStatus();

		if(activateCapacior1 && !cap1){StartCoroutine(cap_chargeTime("activateCapacior1"));}
		if(activateCapacior2 && !cap2){StartCoroutine(cap_chargeTime("activateCapacior2"));}

		if(activateCapacior2 && result[2] && !cap2){lit_bulb1 = true;}else{lit_bulb1 = false;}
	}

	IEnumerator cap_chargeTime(string b){
		yield return new WaitForSeconds(5.0f);
		if(b.Equals("activateCapacior1")){activateCapacior1 = false;}
		if(b.Equals("activateCapacior2")){activateCapacior2 = false;}
	}

	public bool[] pass_bool(){
		bool[] bl = {lit_bulb1};
		return bl;
	}

	public void passCapStatus()
	{	bool[] cap_status = {activateCapacior1 && !cap1, activateCapacior2 && !cap2};
		ct.getCapStatus(cap_status);
	}

}
