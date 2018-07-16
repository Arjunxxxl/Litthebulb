using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit1_5 : MonoBehaviour {

	public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10 , obj11, obj12, obj13, obj14, obj15, obj16,
			obj17, obj18, obj19, obj20, obj21, obj22, obj23, obj24, obj25, obj26 , obj27, obj28, obj29, obj30;

	public GameObject l1;

	bool b1,b2,b3,b4,b5,b6,b7_8a,b7_8b,b7_8c,b9,b10,b11,b12,b13,b14,b15,b16,b17,b18,b19,b20,b21,b22,b23_24a,b23_24b,b23_24c,b25,b26,b27,b28,b29,b30;
	bool short1, short2, short3, a, b, x, light1;
	public bool lit_bulb;

	change_rot cr;
	GameObject click_obj;

	#region Singleton
	public static circuit1_5 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
		b1 = false;		b2 = false;
		b3 = false; 	b4 = false;
		b5 = false;		b6 = false;
		b7_8a = true; b7_8b = false; b7_8c = false;
		b9 = true;		b10 = false;
		b11 = true;		b12 = false;
		b13 = false;	b14 = false;
		b15 = false;	b16 = false;
		b17 = true;		b18 = false;
		b19 = false;	b20 = false;
		b21 = false;	b22 = false;
		b23_24a = false; b23_24b =false; b23_24c = true;
		b25 = true; 	b26 = false;
		b27 = true;		b28 = false;
		b29 = false;	b30 = false;
		light1 = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		set_boolval();
			
	}

	void set_boolval(){
		click_obj = cr.pass_gameobject();
		
		if(click_obj==null){return;}

		//Debug.Log(obj1.transform.eulerAngles.y);
		if(click_obj == obj1){
		if(obj1.transform.eulerAngles.y == 90.0f || obj1.transform.eulerAngles.y == 270.0f){ b1 = true; } else{b1=false;}
		}
		if(click_obj == obj2){
		if(obj2.transform.eulerAngles.y == 90.0f || obj2.transform.eulerAngles.y == 270.0f){ b2 = true; } else{b2=false;}
		}
		if(click_obj == obj3){
		if(obj3.transform.eulerAngles.y == 0.0f){ b3 = true; } else{b3=false;}
		}
		if(click_obj == obj4){
		if(obj4.transform.eulerAngles.y == 270.0f){ b4 = true; } else{b4=false;}
		}
		if(click_obj == obj16){
		if(obj16.transform.eulerAngles.y == 90.0f){ b16 = true; } else{b16=false;}
		}
		if(click_obj == obj17){
		if(obj17.transform.eulerAngles.y == 270.0f){ b17 = true; } else{b17=false;}
		}
		if(click_obj == obj18){
		if(obj18.transform.eulerAngles.y == 180.0f){ b18 = true; } else{b18=false;}
		}
		if(click_obj == obj19){
		if(obj19.transform.eulerAngles.y == 0.0f){ b19 = true; } else{b19=false;}
		}


		
		if(click_obj == obj5){
		if(obj5.transform.eulerAngles.y == 180.0f || obj5.transform.eulerAngles.y == 270.0f){ b5 = true; } else{b5=false;}
		}
		if(click_obj == obj6){
		if(obj6.transform.eulerAngles.y == 0.0f || obj6.transform.eulerAngles.y == 270.0f){ b6 = true; } else{b6=false;}
		}
		
		if(click_obj == obj9){
		if(obj9.transform.eulerAngles.y == 180.0f){ b9 = true; } else{b9=false;}
		}
		if(click_obj == obj10){
		if(obj10.transform.eulerAngles.y == 90.0f){ b10 = true; } else{b10=false;}
		}
		if(click_obj == obj27){
		if(obj27.transform.eulerAngles.y == 90.0f || obj27.transform.eulerAngles.y == 270.0f){ b27 = true; } else{b27=false;}
		}
		if(click_obj == obj28){
		if(obj28.transform.eulerAngles.y == 90.0f || obj28.transform.eulerAngles.y == 270.0f){ b28 = true; } else{b28=false;}
		}
		if(click_obj == obj11){
		if(obj11.transform.eulerAngles.y == 90.0f || obj11.transform.eulerAngles.y == 270.0f){ b11 = true; } else{b11=false;}
		}
		if(click_obj == obj20){
		if(obj20.transform.eulerAngles.y == 90.0f || obj20.transform.eulerAngles.y == 270.0f){ b20 = true; } else{b20=false;}
		}
		if(click_obj == obj12){
		if(obj12.transform.eulerAngles.y == 0.0f || obj12.transform.eulerAngles.y == 180.0f){ b12 = true; } else{b12=false;}
		}
		if(click_obj == obj13){
		if(obj13.transform.eulerAngles.y == 0.0f || obj13.transform.eulerAngles.y == 180.0f){ b13 = true; } else{b13=false;}
		}
		if(click_obj == obj14){
		if(obj14.transform.eulerAngles.y == 0.0f || obj14.transform.eulerAngles.y == 180.0f){ b14 = true; } else{b14=false;}
		}
		if(click_obj == obj15){
		if(obj15.transform.eulerAngles.y == 0.0f || obj15.transform.eulerAngles.y == 180.0f){ b15 = true; } else{b15=false;}
		}
		if(click_obj == obj21){
		if(obj21.transform.eulerAngles.y == 90.0f){ b21 = true; } else{b21=false;}
		}
		if(click_obj == obj22){
		if(obj22.transform.eulerAngles.y == 180.0f){ b22 = true; } else{b22=false;}
		}
		
		
		if(click_obj == obj25){
		if(obj25.transform.eulerAngles.y == 270.0f){ b25 = true; } else{b25=false;}
		}
		if(click_obj == obj26){
		if(obj26.transform.eulerAngles.y == 0.0f){ b26 = true; } else{b26=false;}
		}
		if(click_obj == obj29){
		if(obj29.transform.eulerAngles.y == 90.0f || obj29.transform.eulerAngles.y == 270.0f){ b29 = true; } else{b29=false;}
		}
		if(click_obj == obj30){
		if(obj30.transform.eulerAngles.y == 90.0f || obj30.transform.eulerAngles.y == 270.0f){ b30 = true; } else{b30=false;}
		}


		if(click_obj == obj7 || click_obj == obj8){
		if(obj7.transform.eulerAngles.y == 90.0f && obj8.transform.eulerAngles.y == 90.0f){ b7_8a = true; }else{b7_8a=false;}
		if((obj7.transform.eulerAngles.y == 90.0f && obj8.transform.eulerAngles.y == 180.0f) || 
			(obj7.transform.eulerAngles.y == 0.0f && obj8.transform.eulerAngles.y == 900.0f)){ b7_8b = true; }else{b7_8b=false;}
		if(obj7.transform.eulerAngles.y == 0.0f && obj8.transform.eulerAngles.y == 180.0f){ b7_8c = true; }else{b7_8c=false;}
		}

		if(click_obj == obj23 || click_obj == obj24){
		if(obj23.transform.eulerAngles.y == 270.0f && obj24.transform.eulerAngles.y == 270.0f){ b23_24a = true; }else{b23_24a=false;}
		if((obj23.transform.eulerAngles.y == 90.0f && obj24.transform.eulerAngles.y == 270.0f) ||
		  (obj23.transform.eulerAngles.y == 270.0f && obj24.transform.eulerAngles.y == 90.0f)){ b23_24b = true; }else{b23_24b=false;}

		if(obj23.transform.eulerAngles.y == 90.0f && obj24.transform.eulerAngles.y == 90.0f){ b23_24c = true; }else{b23_24c=false;}
		}

		if(click_obj == l1){
		if(l1.transform.eulerAngles.y == 90.0f || l1.transform.eulerAngles.y == 270.0f){ light1 = true; }else{light1=false;}
		}

		a =  (b1&&b2) && (b3&&b4) && (b16&&b17) && (b18&&b19);
		b = (b5&&b6) && (b12&&b13) && (b14&&b15) && (b21&&b22);

		short1 = (b20&&b11);
		short2 = (b9&&b10) && (b27&&b28);
		short3 = (b25&&b26) && (b29&&b30);

		x = a&&b;

		

		if(x && light1){
			if((b7_8a&&!short1) && (b23_24a || (b23_24b) || (b23_24c&&!short3))) {
				lit_bulb  =true;
			}else if(b7_8b && (b23_24a || (b23_24b) || (b23_24c&&!short3))){
				lit_bulb = true;
			}else if((b7_8c&&!short2) && (b23_24a || (b23_24b) || (b23_24c&&!short3))){
				lit_bulb = true;
			}else {
				lit_bulb = false;
			}
		}else{
			lit_bulb = false;
		}
		


	}

	public bool pass_bool(){
		return lit_bulb;
	}

}
