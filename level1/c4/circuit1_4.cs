using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit1_4 : MonoBehaviour {

	
	public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10 , obj11, obj12, obj13, obj14, obj15, obj16;

	public GameObject l1,l2;

	change_rot cr;
	GameObject click_obj;

	bool b1,b2,b3_4a,b3_4b,b3_4c,b5,b6,b7,b8,b9,b10,b11,b12,b13,b14,b15,b16,l_1,l_2;
	bool x , left, right, mid;
	public bool lit_bulb;
	public bool lit_bulb2;

	#region Singleton
	public static circuit1_4 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
		b1 = false;		b2 = true;
		b5 = false;		b6 = true;
		b3_4a = true; b3_4b= false; b3_4c = false;
		b7 = false;		b8 = false;
		b9 = false;		b10 = false;
		b11 = false;	b12 = false;
		b13 = true; 	b14 = false;
		b15 = false;	b16 = false;
		l_1 = false;	l_2 = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		set_boolval();
			
	}

	void set_boolval(){
		click_obj = cr.pass_gameobject();

		if(click_obj==null){return;}

		if(click_obj == obj1){
		if(obj1.transform.eulerAngles.y == 0.0f || obj1.transform.eulerAngles.y == 180.0f){ b1 = true; } else{b1=false;}
		}
		if(click_obj == obj2){
		if(obj2.transform.eulerAngles.y == 0.0f || obj2.transform.eulerAngles.y == 180.0f){ b2 = true; } else{b2=false;}
		}
		if(click_obj == obj5){
		if(obj5.transform.eulerAngles.y == 90.0f || obj5.transform.eulerAngles.y == 270.0f){ b5 = true; } else{b5=false;}
		}
		if(click_obj == obj6){
		if(obj6.transform.eulerAngles.y == 90.0f || obj6.transform.eulerAngles.y == 270.0f){ b6 = true; } else{b6=false;}
		}
		if(click_obj == obj7){
		if(obj7.transform.eulerAngles.y == 90.0f || obj7.transform.eulerAngles.y == 270.0f){ b7 = true; } else{b7=false;}
		}
		if(click_obj == obj8){
		if(obj8.transform.eulerAngles.y == 90.0f || obj8.transform.eulerAngles.y == 270.0f){ b8 = true; } else{b8=false;}
		}
		if(click_obj == obj9){
		if(obj9.transform.eulerAngles.y == 270.0f){ b9 = true; } else{b9=false;}
		}
		if(click_obj == obj10){
		if(obj10.transform.eulerAngles.y == 0.0f || obj10.transform.eulerAngles.y == 180.0f){ b10 = true; } else{b10=false;}
		}
		if(click_obj == obj11){
		if(obj11.transform.eulerAngles.y == 0.0f || obj11.transform.eulerAngles.y == 180.0f){ b11 = true; } else{b11=false;}	
		}
		if(click_obj == obj12){
		if(obj12.transform.eulerAngles.y == 90.0f){ b12= true; } else{b12=false;}
		}
		if(click_obj == obj13){
		if(obj13.transform.eulerAngles.y == 0.0f || obj13.transform.eulerAngles.y == 180.0f){ b13 = true; } else{b13=false;}
		}
		if(click_obj == obj14){
		if(obj14.transform.eulerAngles.y == 0.0f){ b14= true; } else{b14=false;}
		}
		if(click_obj == obj15){
		if(obj15.transform.eulerAngles.y == 0.0f || obj15.transform.eulerAngles.y == 180.0f){ b15 = true; } else{b15=false;}
		}
		if(click_obj == obj16){
		if(obj16.transform.eulerAngles.y == 180.0f){ b16= true; } else{b16=false;}
		}
		if(click_obj == l1){
		if(l1.transform.eulerAngles.y == 0.0f || l1.transform.eulerAngles.y == 180.0f){ l_1 = true; } else{l_1=false;}
		}
		if(click_obj == l2){
		if(l2.transform.eulerAngles.y == 0.0f || l2.transform.eulerAngles.y == 180.0f){ l_2 = true; } else{l_2=false;}
		}

		
		if(click_obj == obj3 || click_obj == obj4){
		if(obj3.transform.eulerAngles.y == 90.0f && obj4.transform.eulerAngles.y == 270.0f){ b3_4a= true; } else{b3_4a=false;}

		if((obj3.transform.eulerAngles.y == 90.0f && obj4.transform.eulerAngles.y == 180.0f) || 
		   (obj3.transform.eulerAngles.y == 180.0f && obj4.transform.eulerAngles.y == 180.0f) ||
		   (obj3.transform.eulerAngles.y == 180.0f && obj4.transform.eulerAngles.y == 270.0f)
		)
		{ b3_4b= true; } else{b3_4b=false;}

		if((obj3.transform.eulerAngles.y == 90.0f && obj4.transform.eulerAngles.y == 0.0f) || 
		   (obj3.transform.eulerAngles.y == 0.0f && obj4.transform.eulerAngles.y == 0.0f) ||
		   (obj3.transform.eulerAngles.y == 0.0f && obj4.transform.eulerAngles.y == 270.0f)
		)
		{ b3_4c= true; } else{b3_4c=false;}

		}

		left = ((b7&&b8) && (b14&&b13) && (b12&&b14) && l_1);
		right = ((b9&&b16) && (b5&&b6) && (b10&&b11) && l_2);
		mid = (b1&&b2);
		x = ((left && right) && mid);

		Debug.Log("left" + left);
		Debug.Log("mid" + mid);
		Debug.Log("right" + right);

		if(x&&b3_4a){
			lit_bulb = true;
			lit_bulb2 = true;
		}else if(mid && (b3_4a|| b3_4b) && left && !right){
			lit_bulb = true;
			lit_bulb2 = false;
		}else if(mid && (b3_4a || b3_4c)&& right && !left){
			lit_bulb = false;
			lit_bulb2 = true;
		} else {
			lit_bulb = false;
			lit_bulb2 = false;
		}


	}

	public bool pass_bool(){
		return lit_bulb;
	}

	public bool pass_bool2(){
		return lit_bulb2;
	}
}
