using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cap_time : MonoBehaviour {

	public GameObject[] cap_time_indication;
	bool[] cap_status = {false};
	
	int i;

	#region Singleton
	public static cap_time Instance;
	void Awake()
	{
		Instance = this;	
	}
	#endregion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(cap_time_indication.Length ==0) {return;}
		for(i=0; i<cap_status.Length; i++){
		if(cap_status[i]) {cap_time_indication[i].SetActive(true);}
		}
	}

	public void getCapStatus(bool[] b)
	{	
		cap_status = b;
	}

	public bool[] passCapStatus()
	{	
		return cap_status;
	}

	

}
