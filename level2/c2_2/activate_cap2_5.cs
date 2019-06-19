using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_cap2_5 : MonoBehaviour {

	public GameObject capacitor1,capacitor2,capacitor3;
	public GameObject cappos1,cappos2,cappos3;
	public bool cap1 = false,cap2=false,cap3 = false;
	public bool activateCapacior1 = false,activateCapacior2 = false,activateCapacior3 = false;

	public bool lit_bulb1 ;

	change_rot cr;

	circuit2_5 c;

	cap_time ct;

	bool[] result;

	#region Singleton
	public static activate_cap2_5 Instance;
	void Awake()
	{
		Instance = this;	
	}
	#endregion
	// Use this for initialization
	void Start () {
		c = circuit2_5.Instance;
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


		result = c.pass_bool1();

		if(result[0] && cap1){
				activateCapacior1 = true;
				
		}
		if(result[1] && cap2){
			activateCapacior2 = true;
		}
		if(result[2] && cap3 && activateCapacior1 && activateCapacior2){
			activateCapacior3 = true;
		}

		passCapStatus();

		if(activateCapacior1 && (!cap1 || !result[0] ) ){StartCoroutine(cap_chargeTime("activateCapacior1"));}
		if(activateCapacior2 && (!cap2 || !result[1] ) ){StartCoroutine(cap_chargeTime("activateCapacior2"));}
		if(activateCapacior3 && (!cap3 || !result[2] || !activateCapacior1 || !activateCapacior2) ){StartCoroutine(cap_chargeTime("activateCapacior2"));}


		if(activateCapacior3 && result[3] && !cap3){lit_bulb1 = true;}else{lit_bulb1 = false;}
	}
	
	IEnumerator cap_chargeTime(string b){
		yield return new WaitForSeconds(5.0f);
		if(b.Equals("activateCapacior1")){activateCapacior1 = false;}
		if(b.Equals("activateCapacior2")){activateCapacior2 = false;}
		if(b.Equals("activateCapacior3")){activateCapacior3 = false;}
	}

	public bool[] pass_bool(){
		bool[] bl = {lit_bulb1};
		return bl;
	}

	public void passCapStatus()
	{	bool[] cap_status = {activateCapacior1 && (!cap1 || !result[0] ), activateCapacior2 && (!cap2 || !result[1] )
							,	 activateCapacior3 && (!cap3 || !result[2] ) };
		ct.getCapStatus(cap_status);
	}

}
