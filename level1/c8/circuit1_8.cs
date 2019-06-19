using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit1_8 : MonoBehaviour {

public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10 , obj11, obj12, obj15, obj13, obj14, obj16,
			obj17, obj18, obj19, obj20, obj21, obj22, obj23, obj24, obj25, obj26, obj27, obj28, obj29, obj30, obj31, 
			obj32, obj33, obj34, obj35, obj36, obj37, obj38, obj39, obj40 , obj41, obj42, obj43, obj44, obj45, obj46,
			obj47, obj48 ;

	public GameObject l1;

	bool b1,b2,b3,b4,b5,b6,b7,b8,b9_10a,b9_10b,b11,b12,b13,b14,b15,b16,b17_35a,b17_35b,b18_19a,b18_19b,b20,b21,b22,b23,b24
	,b25,b26,b27,b28,b29,b30,b31,b32,b33,b34,b36,b37,b38,b39,b40,b41,b42,b43,b44,b45,b46,b47,b48;
	bool short1, short2, x, a1, a2, a, light1;

	change_rot cr;
	GameObject click_obj;

	public bool lit_bulb;

	#region Singleton
	public static circuit1_8 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		short1 = false;
		short2 = false;
		x = false;
		cr = change_rot.Instance;

		b1 = false; b2 = false; b3 = false; b4 = false; b5 = false; b6 = false; b7 = true; b8 = false; b9_10a = false; b9_10b = false;
		b11 =false; b12 = false; b13 = true; b14 = false; b15 = false; b16 = true; b18_19a = true; b18_19b = false; b17_35a = false; b17_35b = false;
		b20 = true; b21 = false; b22 = true; b23 = true; b24 = false; b25 = false; b26 = true; b27 = false; b28 = false; b29= false; b30 = false;
		b31 = true; b32 = true; b33 = false; b34 = false; b36 = false; b37 = false; b38 = true; b39 = true; b40 = false; b41 = false; 
		b42 = false; b43 = false; b44 = false; b45 = true; b46 = true; b47 = false; b48 = false;
		light1 = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		set_boolval();
			
	}

	void set_boolval(){
		click_obj = cr.pass_gameobject();
		if(click_obj == null) {return;}

		if(click_obj == obj1){
		if(obj1.transform.eulerAngles.y == 0.0f || obj1.transform.eulerAngles.y == 180.0f){ b1 = true; } else{b1=false;}
		}
		if(click_obj == obj2){
		if(obj2.transform.eulerAngles.y == 0.0f || obj2.transform.eulerAngles.y == 180.0f){ b2 = true; } else{b2=false;}
		}
		if(click_obj == obj3){
		if(obj3.transform.eulerAngles.y == 0.0f || obj3.transform.eulerAngles.y == 180.0f){ b3 = true; } else{b3=false;}
		}
		if(click_obj == obj4){
		if(obj4.transform.eulerAngles.y == 0.0f || obj4.transform.eulerAngles.y == 180.0f){ b4 = true; } else{b4=false;}
		}
		if(click_obj == obj5){
		if(obj5.transform.eulerAngles.y == 90.0f ){ b5 = true; } else{b5=false;}
		}
		if(click_obj == obj6){
		if(obj6.transform.eulerAngles.y == 270.0f){ b6 = true; } else{b6=false;}
		}
		if(click_obj == obj7){
		if(obj7.transform.eulerAngles.y == 90.0f || obj7.transform.eulerAngles.y == 270.0f){ b7 = true; } else{b7=false;}
		}
		if(click_obj == obj8){
		if(obj8.transform.eulerAngles.y == 90.0f || obj8.transform.eulerAngles.y == 270.0f){ b8 = true; } else{b8=false;}
		}
		if(click_obj == obj20){
		if(obj20.transform.eulerAngles.y == 0.0f || obj21.transform.eulerAngles.y == 180.0f){ b20 = true; } else{b20=false;}
		}
		if(click_obj == obj25){
		if(obj25.transform.eulerAngles.y == 90.0f || obj25.transform.eulerAngles.y == 270.0f){ b25 = true; } else{b25=false;}
		}
		if(click_obj == obj26){
		if(obj26.transform.eulerAngles.y == 90.0f || obj26.transform.eulerAngles.y == 270.0f){ b26 = true; } else{b26=false;}
		}
		if(click_obj == obj27){
		if(obj27.transform.eulerAngles.y == 90.0f){ b27 = true; } else{b27=false;}
		}
		if(click_obj == obj28){
		if(obj28.transform.eulerAngles.y == 0.0f){ b28 = true; } else{b28=false;}
		}
		if(click_obj == obj29){
		if(obj29.transform.eulerAngles.y == 0.0f || obj29.transform.eulerAngles.y == 180.0f){ b29 = true; } else{b29=false;}
		}
		if(click_obj == obj30){
		if(obj30.transform.eulerAngles.y == 0.0f || obj30.transform.eulerAngles.y == 180.0f){ b30 = true; } else{b30=false;}
		}
		if(click_obj == obj31){
		if(obj31.transform.eulerAngles.y == 0.0f || obj31.transform.eulerAngles.y == 180.0f){ b31 = true; } else{b31=false;}
		}
		if(click_obj == obj32){
		if(obj32.transform.eulerAngles.y == 0.0f || obj32.transform.eulerAngles.y == 180.0f){ b32 = true; } else{b32=false;}
		}
		if(click_obj == obj33){
		if(obj33.transform.eulerAngles.y == 90.0f || obj33.transform.eulerAngles.y == 270.0f){ b33 = true; } else{b33=false;}
		}
		if(click_obj == obj37){
		if(obj37.transform.eulerAngles.y == 0.0f || obj37.transform.eulerAngles.y == 180.0f){ b37 = true; } else{b37=false;}
		}
		if(click_obj == obj38){
		if(obj38.transform.eulerAngles.y == 90.0f || obj38.transform.eulerAngles.y == 270.0f){ b38 = true; } else{b38=false;}
		}
		if(click_obj == obj39){
		if(obj39.transform.eulerAngles.y == 90.0f || obj39.transform.eulerAngles.y == 180.0f){ b39 = true; } else{b39=false;}
		}
		if(click_obj == obj40){
		if(obj40.transform.eulerAngles.y == 0.0f || obj40.transform.eulerAngles.y == 180.0f){ b40 = true; } else{b40=false;}
		}
		if(click_obj == l1){
		if(l1.transform.eulerAngles.y == 0.0f || l1.transform.eulerAngles.y == 180.0f){ light1 = true; } else{light1=false;}
		}
		
		
		if(click_obj == obj9 || click_obj == obj10){
		if(obj9.transform.eulerAngles.y == 90.0f && obj10.transform.eulerAngles.y == 270.0f){ b9_10a = true;} else{b9_10a=false;}
		if((obj9.transform.eulerAngles.y == 90.0f && obj10.transform.eulerAngles.y == 90.0f) ||
			(obj9.transform.eulerAngles.y == 270.0f && obj10.transform.eulerAngles.y == 270.0f) ||
			(obj9.transform.eulerAngles.y == 270.0f && obj10.transform.eulerAngles.y == 90.0f)){b9_10b = true;}else{b9_10b=false;}
		}	

		
		if(click_obj == obj18 || click_obj == obj19){
		if(obj18.transform.eulerAngles.y == 270.0f && obj19.transform.eulerAngles.y == 0.0f){ b18_19a = true;} else{b18_19a=false;}
		if((obj18.transform.eulerAngles.y == 90.0f && obj19.transform.eulerAngles.y == 0.0f) ||
			(obj18.transform.eulerAngles.y == 90.0f && obj19.transform.eulerAngles.y == 270.0f) ||
			(obj18.transform.eulerAngles.y == 270.0f && obj19.transform.eulerAngles.y == 270.0f)){b18_19b = true;}else{b18_19b=false;}
		}	


		if(click_obj == obj35 || click_obj == obj17){
		if(obj17.transform.eulerAngles.y == 90.0f && obj35.transform.eulerAngles.y == 270.0f){ b17_35a = true;} else{b17_35a=false;}
		if((obj17.transform.eulerAngles.y == 90.0f && obj35.transform.eulerAngles.y == 180.0f) ||
			(obj17.transform.eulerAngles.y == 270.0f && obj35.transform.eulerAngles.y == 180.0f) ||
			(obj17.transform.eulerAngles.y == 270.0f && obj35.transform.eulerAngles.y == 270.0f)){b17_35b = true;}else{b17_35b=false;}	
		}	


		if(b9_10a){
			//short1
			
			if(click_obj == obj11){
			if(obj11.transform.eulerAngles.y == 0.0f || obj11.transform.eulerAngles.y == 180.0f){ b11 = true; } else{b11=false;}
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
			if(click_obj == obj16){
			if(obj16.transform.eulerAngles.y == 0.0f || obj16.transform.eulerAngles.y == 180.0f){ b16 = true; } else{b16=false;}
			}
			//over
			short1 = (b11&&b12) && (b13&&b14) && (b15&&b16);
		}
		if(b18_19a){
			//short2
			
			if(click_obj == obj21){
			if(obj21.transform.eulerAngles.y == 0.0f || obj21.transform.eulerAngles.y == 180.0f){ b21 = true; } else{b21=false;}
			}
			if(click_obj == obj22){
			if(obj22.transform.eulerAngles.y == 0.0f || obj22.transform.eulerAngles.y == 180.0f){ b22 = true; } else{b22=false;}
			}
			if(click_obj == obj23){
			if(obj23.transform.eulerAngles.y == 0.0f || obj23.transform.eulerAngles.y == 180.0f){ b23 = true; } else{b23=false;}
			}
			if(click_obj == obj24){
			if(obj24.transform.eulerAngles.y == 0.0f || obj24.transform.eulerAngles.y == 180.0f){ b24 = true; } else{b24=false;}
			}
			//over
			short2 = (b21&&b22) && (b23&&b44);
		}

		if(b17_35a){
			//short3
			
			if(click_obj == obj34){
			if(obj34.transform.eulerAngles.y == 90.0f || obj34.transform.eulerAngles.y == 270.0f){ b34 = true; } else{b34=false;}
			}
			if(click_obj == obj36){
			if(obj36.transform.eulerAngles.y == 90.0f || obj36.transform.eulerAngles.y == 270.0f){ b36 = true; } else{b36=false;}
			}
			if(click_obj == obj41){
			if(obj41.transform.eulerAngles.y == 180.0f ){ b41 = true; } else{b41=false;}
			}
			if(click_obj == obj42){
			if(obj42.transform.eulerAngles.y == 270.0f){ b42 = true; } else{b42=false;}
			}
			if(click_obj == obj43){
			if(obj43.transform.eulerAngles.y == 0.0f || obj43.transform.eulerAngles.y == 180.0f){ b43 = true; } else{b43=false;}
			}
			if(click_obj == obj44){
			if(obj44.transform.eulerAngles.y == 0.0f || obj44.transform.eulerAngles.y == 180.0f){ b44 = true; } else{b44=false;}
			}
			if(click_obj == obj45){
			if(obj45.transform.eulerAngles.y == 0.0f || obj45.transform.eulerAngles.y == 180.0f){ b45 = true; } else{b45=false;}
			}
			if(click_obj == obj46){
			if(obj46.transform.eulerAngles.y == 0.0f || obj46.transform.eulerAngles.y == 180.0f){ b46 = true; } else{b46=false;}
			}
			if(click_obj == obj47){
			if(obj47.transform.eulerAngles.y == 0.0f || obj47.transform.eulerAngles.y == 180.0f){ b47 = true; } else{b47=false;}
			}
			if(click_obj == obj48){
			if(obj48.transform.eulerAngles.y == 0.0f || obj48.transform.eulerAngles.y == 180.0f){ b48 = true; } else{b48=false;}
			}
			x = (b34&&b36) && (b41&&b42) && (b43&&b44) && (b45&&b46) && (b47&&b48);
		}


		a1 = (b1&&b2) && (b3&&b4) && (b5&&b6) && (b7&&b8) && (b20&&b25) && (b26&&b27);
		a2 = (b29&&b28) && (b30&&b31) && (b32&&b33) && (b37&&b38) && (b39&&b40);
		a = a1 && a2;
		//Debug.Log(x);

		if(a && light1){
			
			if(((b9_10b) || (b9_10a&&!short1)) && ((b18_19b) || (b18_19a&&!short2)) && ((b17_35b) || (b17_35a&&!x))){
				lit_bulb = true;
			}
			else{
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
