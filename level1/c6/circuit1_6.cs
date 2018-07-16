using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit1_6 : MonoBehaviour {

	public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10 , obj11, obj12, obj13, obj14, obj15, obj16,
			obj17, obj18, obj19, obj20, obj21, obj22, obj23, obj24, obj25, obj27, obj28;

	public GameObject l1;

	change_rot cr;
	GameObject click_obj;

	bool b1,b2,b3,b4,b5_8a,b5_8b,b6,b7,b9,b10,b11,b12,b13,b14,b15,b16,b17,b18,b19_20a,b19_20b,b21,b22,b23,b24,b25,b27,b28;
	bool short1, short2, a, x, light1;
	public bool lit_bulb;

	#region Singleton
	public static circuit1_6 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
		b1 = false; 	b2 = false;
		b3 = false;		b4 = false;
		b5_8a = false;	b5_8b = false;
		b6 = false;		b7 = false;
		b9 = false;		b10 = false;
		b11 = true; 	b12 = false;
		b13 = false;	b14 = false;
		b15 = false;	b16 = false;
		b17 = false;	b18 = true;
		b19_20a= false;	b19_20b = false;
		b21 = true;		b22 = false;
		b23 = true;		b24 = false;
		b25 = false;	b27 = true;
		b28 = true;		light1 = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		set_boolval();
			
	}

	void set_boolval(){
		click_obj = cr.pass_gameobject();
		if(click_obj == null){return;}

		if(click_obj == obj1){
		if(obj1.transform.eulerAngles.y == 0.0f || obj1.transform.eulerAngles.y == 180.0f){ b1 = true; } else{b1=false;}
		}
		if(click_obj == obj2){
		if(obj2.transform.eulerAngles.y == 0.0f || obj2.transform.eulerAngles.y == 180.0f){ b2 = true; } else{b2=false;}
		}
		if(click_obj == obj3){
		if(obj3.transform.eulerAngles.y == 90.0f ){ b3 = true; } else{b3=false;}
		}
		if(click_obj == obj4){
		if(obj4.transform.eulerAngles.y == 0.0f ){ b4 = true; } else{b4=false;}
		}



		if(click_obj == obj5 || click_obj == obj8){
		if(obj5.transform.eulerAngles.y == 90.0f && obj8.transform.eulerAngles.y == 0.0f){ b5_8a = true; } else{b5_8a=false;}
		if((obj5.transform.eulerAngles.y == 90.0f && obj8.transform.eulerAngles.y == 90.0f) || 
			(obj5.transform.eulerAngles.y == 270.0f && obj8.transform.eulerAngles.y == 90.0f) || 
			(obj5.transform.eulerAngles.y == 270.0f && obj8.transform.eulerAngles.y == 0.0f)){ b5_8b = true; } else{b5_8b=false;}
		}


		if(click_obj == obj6){
		if(obj6.transform.eulerAngles.y == 0.0f || obj6.transform.eulerAngles.y == 180.0f){ b6 = true; } else{b6=false;}
		}
		if(click_obj == obj7){
		if(obj7.transform.eulerAngles.y == 0.0f || obj7.transform.eulerAngles.y == 180.0f){ b7 = true; } else{b7=false;}
		}
		if(click_obj == obj9){
		if(obj9.transform.eulerAngles.y == 270.0f || obj9.transform.eulerAngles.y == 180.0f){ b9 = true; } else{b9=false;}
		}
		if(click_obj == obj10){
		if(obj10.transform.eulerAngles.y == 0.0f || obj10.transform.eulerAngles.y == 180.0f){ b10 = true; } else{b10=false;}
		}
		if(click_obj == obj11){
		if(obj11.transform.eulerAngles.y == 0.0f || obj11.transform.eulerAngles.y == 180.0f){ b11 = true; } else{b11=false;}
		}
		if(click_obj == obj12){
		if(obj12.transform.eulerAngles.y == 90.0f){ b12 = true; } else{b12=false;}
		}
		if(click_obj == obj13){
		if(obj13.transform.eulerAngles.y == 270.0f){ b13 = true; } else{b13=false;}
		}
		if(click_obj == obj14){
		if(obj14.transform.eulerAngles.y == 0.0f || obj14.transform.eulerAngles.y == 270.0f){ b14 = true; } else{b14=false;}
		}
		if(click_obj == obj15){
		if(obj15.transform.eulerAngles.y == 180.0f){ b15 = true; } else{b15=false;}
		}
		if(click_obj == obj16){
		if(obj16.transform.eulerAngles.y == 0.0f || obj16.transform.eulerAngles.y == 270.0f){ b16 = true; } else{b16=false;}
		}
		if(click_obj == obj17){
		if(obj17.transform.eulerAngles.y == 180.0f){ b17 = true; } else{b17=false;}
		}
		if(click_obj == obj18){
		if(obj18.transform.eulerAngles.y == 0.0f || obj18.transform.eulerAngles.y == 180.0f){ b18 = true; } else{b18=false;}
		}


		if(click_obj == obj19 || click_obj == obj20){
		if(obj19.transform.eulerAngles.y == 270.0f && obj20.transform.eulerAngles.y == 180.0f){ b19_20a = true; } else{b19_20a=false;}
		if((obj19.transform.eulerAngles.y == 90.0f && obj20.transform.eulerAngles.y == 270.0f) || 
			(obj19.transform.eulerAngles.y == 90.0f && obj20.transform.eulerAngles.y == 180.0f) || 
			(obj19.transform.eulerAngles.y == 270.0f && obj20.transform.eulerAngles.y == 270.0f)){ b19_20b = true; } else{b19_20b=false;}
		}


		if(click_obj == obj21){
		if(obj21.transform.eulerAngles.y == 0.0f || obj21.transform.eulerAngles.y == 90.0f){ b21 = true; } else{b21=false;}
		}
		if(click_obj == obj22){
		if(obj22.transform.eulerAngles.y == 0.0f || obj22.transform.eulerAngles.y == 180.0f){ b22 = true; } else{b22=false;}
		}
		if(click_obj == obj23){
		if(obj23.transform.eulerAngles.y == 0.0f || obj23.transform.eulerAngles.y == 180.0f){ b23 = true; } else{b23=false;}
		}
		if(click_obj == obj24){
		if(obj24.transform.eulerAngles.y == 180.0f){ b24 = true; } else{b24=false;}
		}
		if(click_obj == obj25){
		if(obj25.transform.eulerAngles.y == 270.0f){ b25 = true; } else{b25=false;}
		}
		if(click_obj == obj27){
		if(obj27.transform.eulerAngles.y == 0.0f || obj27.transform.eulerAngles.y == 180.0f){ b27 = true; } else{b27=false;}
		}
		if(click_obj == obj28){
		if(obj28.transform.eulerAngles.y == 0.0f || obj28.transform.eulerAngles.y == 180.0f){ b28 = true; } else{b28=false;}
		}
		if(click_obj == l1){
		if(l1.transform.eulerAngles.y == 0.0f || l1.transform.eulerAngles.y == 180.0f){ light1 = true; } else{light1=false;}
		}

		a = (b1&&b2) && (b3&&b4) && (b9&&b10) && (b11&&b12) && (b13&&b14) && (b15&&b16) && (b17&&b18) && (b21&&b24) && (b25&&b27) && b28;
		short1 = (b6&&b7);
		short2 = (b22&&b23);

		/*Debug.Log("A" + a);
		Debug.Log("short" + short1);
		Debug.Log("short2" + short2);
		Debug.Log("light" + light1);

		Debug.Log("B5_8A" + b5_8a);
		Debug.Log("B5_8B" + b5_8b);
		Debug.Log("B19_20A" + b19_20a);
		Debug.Log("B19_20B" + b19_20b);*/

		if(a&&light1) {
			
			if((b5_8a&&!short1) && ((b19_20a&&!short2) || b19_20b)){
				lit_bulb = true;
			}else if((b5_8b) &&((b19_20a&&!short2) || b19_20b)){
				lit_bulb = true;
			}else{
				lit_bulb = false;
			}

		}else{
			lit_bulb = false;
		}

		//Debug.Log("lit_bulb " + lit_bulb);

	}

	public bool pass_bool(){
		return lit_bulb;
	}
}
