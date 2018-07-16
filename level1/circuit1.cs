using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit1 : MonoBehaviour {


	public GameObject obj1, obj2, obj5, obj6, obj7, obj8, obj9, obj10;

	change_rot cr;
	GameObject click_obj;


	bool b1,b2,b5,b6,b7,b8,b9,b10;
	public bool lit_bulb;

	#region Singleton
	public static circuit1 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
		click_obj = cr.pass_gameobject();
		b1 = false;
		b2 = false;
		b5 = true;
		b6 = false;
		b7 = false;
		b8 = true;
		b9 = true;
		b10 = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		set_boolval();
			
	}

	void set_boolval(){
		click_obj = cr.pass_gameobject();
		if(click_obj == null){return;}

		if(click_obj == obj1){
		if(obj1.transform.eulerAngles.y == 90.0f || obj1.transform.eulerAngles.y == 270.0f){ b1 = true; } else{b1=false;}
		}
		if(click_obj == obj5){
		if(obj5.transform.eulerAngles.y == 270.0f){ b5 = true; } else{b5=false;}
		}
		if(click_obj == obj6){
		if(obj6.transform.eulerAngles.y == 180.0f){ b6 = true; } else{b6=false;}
		}
		if(click_obj == obj8){
		if(obj8.transform.eulerAngles.y == 90.0f || obj8.transform.eulerAngles.y == 270.0f){ b8 = true; } else{b8=false;}
		}
		
		if(obj9.transform.eulerAngles.y == 0f){ b9 = true; } else{b9=false;}
		
		
		if(click_obj == obj10){
		if(obj10.transform.eulerAngles.y == 90.0f){ b10 = true; } else{b10=false;}
		}

		
		if(click_obj == obj2){
		if(obj2.transform.eulerAngles.y == 90.0f || obj2.transform.eulerAngles.y == 270.0f){ b2 = true;}else{b2 = false;}
		}
		if(click_obj == obj7){
		if(obj7.transform.eulerAngles.y == 270.0f || obj7.transform.eulerAngles.y == 90.0f){ b7=true;}else{ b7=false;}
		}

		if(((b1&&b2)&&(b5&&b6)&&(b7&&b8)&&(b9&&b10))){
			lit_bulb = true;
		}else {lit_bulb = false;}

		

		
	}

	public bool pass_bool(){
		return lit_bulb;
	}
}
