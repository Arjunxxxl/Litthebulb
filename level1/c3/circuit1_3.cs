using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit1_3 : MonoBehaviour {
public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, l1, l2, l3;


	bool b1,b2,b5,b6,b7,b8,b9,b10,b3,b4, b11;

	change_rot cr;
	GameObject click_obj;

	public bool lit_bulb1;

	#region Singleton
	public static circuit1_3 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
		b1 = false ;		b2 = false ;
		b3 = true ;			b4 = false ;
		b5 = false ;		b6 = false ;
		b7 = true ;			b8 = false ;
		b9 = false ;		b10 = false ;
		b11 = false ;
	}
	
	// Update is called once per frame
	void Update () {

		set_boolval();
			
	}

	void set_boolval(){
		click_obj = cr.pass_gameobject();
		if(click_obj==null){return;}

		if(click_obj==obj1){
		if(obj1.transform.eulerAngles.y == 90.0f){ b1 = true; } else{b1=false;}
		}
		if(click_obj == obj2){
		if(obj2.transform.eulerAngles.y == 0.0f){ b2 = true; } else{b2=false;}
		}
		if(click_obj == obj3){
		if(obj3.transform.eulerAngles.y == 90.0f || obj3.transform.eulerAngles.y == 270.0f){ b3 = true; } else{b3=false;}
		}
		if(click_obj == obj4){
		if(obj4.transform.eulerAngles.y == 90.0f || obj4.transform.eulerAngles.y == 270.0f){ b4 = true; } else{b4=false;}
		}
		if(click_obj == obj5){
		if(obj5.transform.eulerAngles.y == 90.0f || obj5.transform.eulerAngles.y == 270.0f){ b5 = true; } else{b5=false;}
		}
		if(click_obj == obj6){
		if(obj6.transform.eulerAngles.y == 90.0f || obj6.transform.eulerAngles.y == 270.0f){ b6 = true; } else{b6=false;}
		}
		if(click_obj == obj7){
		if(obj7.transform.eulerAngles.y == 180.0f){ b7 = true; } else{b7=false;}
		}
		if(click_obj == obj8){
		if(obj8.transform.eulerAngles.y == 270.0f){ b8 = true; } else{b8=false;}
		}
		if(click_obj == l1){
		if(l1.transform.eulerAngles.y == 90.0f || l1.transform.eulerAngles.y == 270.0f){ b9 = true; } else{b9=false;}
		}
		if(click_obj == l2){
		if(l2.transform.eulerAngles.y == 0.0f || l2.transform.eulerAngles.y == 180.0f){ b10 = true; } else{b10=false;}
		}
		if(click_obj == l3){
		if(l3.transform.eulerAngles.y == 90.0f || l3.transform.eulerAngles.y == 270.0f){ b11 = true; } else{b11=false;}
		}

		if((b1&&b2) && (b3&&b4) &&(b5&&b6) &&(b7&&b8) && (b9&&b10) && (b11)){
			lit_bulb1 = true;
		}else{
			lit_bulb1 = false;
		}
	
	
	}


	public bool pass_bool1(){
		return lit_bulb1;
	}

}
