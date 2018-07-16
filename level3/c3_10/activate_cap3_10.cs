using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_cap3_10 : MonoBehaviour {

	public GameObject capacitor1;
	public GameObject cappos1;
	public bool cap1 = false;
	public bool activateCapacior1 = false;

	public bool lit_bulb1;

	change_rot cr;

	circuit3_10 c;
	bool[] result;
	cap_time ct;

	#region Singleton
	public static activate_cap3_10 Instance;
	void Awake()
	{
		Instance = this;	
	}
	#endregion

	// Use this for initialization
	void Start () {
		c = circuit3_10.Instance;
		cr = change_rot.Instance;
		ct = cap_time.Instance;
	}
	
	
	// Update is called once per frame
	void Update () {
		if(cr.pass_gameobject() == capacitor1){
		if(capacitor1.transform.position == cappos1.transform.position){cap1 = true;}else{cap1 = false;}
		}

		result = c.pass_bool1();

		if(result[0] && cap1 ){
			activateCapacior1 = true;
		}

		passCapStatus();
		
		if(!result[0] || !cap1 ) {
			if(activateCapacior1){
			StartCoroutine(cap_chargeTime("activateCapacior1"));
			}
		}

		if(activateCapacior1 && !cap1 &&result[1])
		 {lit_bulb1 = true;}else{lit_bulb1 = false;}
		
	}

	IEnumerator cap_chargeTime(string b){
		yield return new WaitForSeconds(5.0f);
		if(b.Equals("activateCapacior1")){activateCapacior1 = false;}
	}

	public bool[] pass_bool(){
		bool[] bl = {lit_bulb1};
		return bl;
	}

	public void passCapStatus()
	{	bool[] cap_status = {((!result[0] || !cap1 ) && activateCapacior1)};

		ct.getCapStatus(cap_status);
	}

}
