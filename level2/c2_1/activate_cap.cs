using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_cap : MonoBehaviour {

	public GameObject capacitor;
	public GameObject cappos1;
	public bool cap1 = false;
	public bool activateCapacior = false;

	public bool lit_bulb;

	change_rot cr;

	circuit2_1 c;
	bool[] result;

	cap_time ct;

	#region Singleton
	public static activate_cap Instance;
	void Awake()
	{
		Instance = this;	
	}
	#endregion

	// Use this for initialization
	void Start () {
		c = circuit2_1.Instance;
		cr = change_rot.Instance;
		ct = cap_time.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		

		if(cr.pass_gameobject() == capacitor){
		if(capacitor.transform.position == cappos1.transform.position){cap1 = true;}else{cap1 = false;}
		}

		result = c.pass_bool1();

		if(result[0] && result[1]){
			if(cap1){
				activateCapacior = true;
				
			}
		}

		if(activateCapacior &&( !cap1 || !result[0] || !result[1] ) ){StartCoroutine(cap_chargeTime());}

		passCapStatus();

		if(result[2] && !cap1 && activateCapacior){
				lit_bulb = true;
		}else{
			lit_bulb = false;
		}

		

	}

	IEnumerator cap_chargeTime(){
		yield return new WaitForSeconds(5.0f);
		activateCapacior = false;
	}

	public bool pass_bool(){
		return lit_bulb;
	}

	public void passCapStatus()
	{	
		bool[] cap_status = {activateCapacior &&( !cap1 || !result[0] || !result[1] ) };
		ct.getCapStatus(cap_status);
	}

}
