using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit1_2 : MonoBehaviour {

	
	public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10;


	bool b1,b2,b5_1,b5_2,b5_3,b6_1,b7,b8,b9,b10,b3,b4;
	public bool lit_bulb1, lit_bulb2;


	change_rot cr;
	GameObject click_obj;


	#region Singleton
	public static circuit1_2 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		b1 = false;		b2 = false;
		b3 = false;		b4 = false;
		b7 = true;		b8 = false;
		b9 = false;		b10 = false;
		b5_1 = false;	b5_2 = false;
		b5_3 = false;	b6_1 = false;
		cr = change_rot.Instance;
		click_obj = cr.pass_gameobject();
	}
	
	// Update is called once per frame
	void Update () {
		
		set_boolval();
			
	}

	void set_boolval(){
		click_obj = cr.pass_gameobject();

		if(click_obj==null){return;}

		if(click_obj == obj1){
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
		if(click_obj == obj5 ){
		if(obj5.transform.eulerAngles.y == 90.0f){ b5_1 = true; } else{b5_1 = false;}
		}
		if(click_obj == obj5 || click_obj == obj6){
		if(((obj5.transform.eulerAngles.y == 180.0f) &&
		((obj6.transform.eulerAngles.y == 270.0f) || (obj6.transform.eulerAngles.y == 180.0f) )) ||
		((obj5.transform.eulerAngles.y == 90.0f) &&((obj6.transform.eulerAngles.y == 270.0f) || (obj6.transform.eulerAngles.y == 180.0f) ))
		)
		{b5_2 = true; }else{b5_2 = false;}
		}
		if(click_obj == obj5 || click_obj == obj6){
		if((obj5.transform.eulerAngles.y == 90.0f&&obj6.transform.eulerAngles.y == 90.0f) ||
			(obj5.transform.eulerAngles.y == 270.0f&&obj6.transform.eulerAngles.y == 270.0f) ||
			(obj5.transform.eulerAngles.y == 270.0f&&obj6.transform.eulerAngles.y == 90.0f)
			){b5_3 = true; }else{b5_3 = false;}
		}

		if(click_obj == obj6 ){
		if(obj6.transform.eulerAngles.y == 270.0f){ b6_1 = true; } else{b6_1 = false;}
		//if(obj6.transform.eulerAngles.y == 180.0f){b6_2 = true; }else{b6_2 = false;}
		//if(obj6.transform.eulerAngles.y == 90.0f){b6_3 = true; }else{b6_3 = false;}
		}
		if(click_obj == obj7 ){
		if(obj7.transform.eulerAngles.y == 90.0f || obj7.transform.eulerAngles.y == 270.0f){ b7 = true; } else{b7=false;}
		}
		if(click_obj == obj8 ){
		if(obj8.transform.eulerAngles.y == 90.0f || obj8.transform.eulerAngles.y == 270.0f){ b8 = true; } else{b8=false;}
		}
		if(click_obj == obj9 ){
		if(obj9.transform.eulerAngles.y == 180.0f){ b9 = true; } else{b9=false;}
		}
		if(click_obj == obj10 ){
		if(obj10.transform.eulerAngles.y == 270.0f){ b10 = true; } else{b10=false;}
		}
		
		if((b1&&b2) && (b3&&b4) && (b5_1&&b6_1) && (b7&&b8) && (b9&&b10)){
			lit_bulb1 = true;
			lit_bulb2 = true;
		}
		else if((b1&&b2) && (b3&&b4) && (b5_2)){
			lit_bulb1 = true;
			lit_bulb2 = false;
		}else if((b1&&b2) && (b3&&b4) && (b5_3) && (b7&&b8) && (b9&&b10)){
			lit_bulb1 = false;
			lit_bulb2 = true;
		}
		else{
			lit_bulb1 = false;
			lit_bulb2 = false;}

		/*Debug.Log("1 :-> " + b1);
		Debug.Log("2 :-> " + b2);
		//Debug.Log("5 :-> " + b5);
		//Debug.Log("6 :-> " + b6);
		Debug.Log("7 :-> " + b7);
		Debug.Log("8 :-> " + b8);
		Debug.Log("9 :-> " + b9);
		Debug.Log("10 :-> " + b10);
		Debug.Log("lit_bulb :-> " + lit_bulb1);*/
		
	}

	public bool pass_bool1(){
		return lit_bulb1;
	}

	public bool pass_bool2(){
		return lit_bulb2;
	}
}
