using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit1_10 : MonoBehaviour {
public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10 , obj11, obj12, obj14, obj13, obj15, obj16,
			obj17, obj18, obj19, obj20, obj21, obj22, obj23, obj24, obj25, obj26, obj27, obj28, obj29, obj30, obj31, 
			obj32, obj33, obj34, obj35, obj36, obj37, obj38, obj39, obj40, obj41, obj42, obj43;

	public GameObject l1,l2,l3;

	bool b1,b2,b3_4a,b3_4b,b5,b6,b7,b8,b9_4a,b9_3a,b10,b11,b12,b13,b14,b15,b16,b17,b18,b19,b20,b21,b22,b23_26a,b23_26b,b24_30a,b24_30b
	,b25,b27,b28,b29,b31,b32a,b32b,b33,b34,b35,b36a,b36b,b37,b38a,b38b,b39,b40,b41,b42,b43;
	bool short1, short2, short3, short4, short5, short_net, short_net_a, short_net_b, a1, a2, a3, light1,light2,light3;
	public bool lit_bulb,lit_bulb2,lit_bulb3;

	change_rot cr;
	GameObject click_obj;

	#region Singleton
	public static circuit1_10 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		short1 = false;
		short2 = false;
		short3 = false;
		short5 = false;
		short4 = false;

		cr = change_rot.Instance;

		b1 = false; b2 = false; b5 = false; b6 = false; b7 = false; b8 = false; b10 = false;
		b11 = true; b12 = true; b13 = false; b14 = false; b15 = false; b16 = true;  b17 = false; b18 = false;
		b19 = true; b20 = false; b21 = true; b22 = true; b27 = true; b31 = true; b25 = false; b28 = false; 
		b29 = false; b32a = true; b32b = false; b33 = false; b34 = false; b35 =false; b36a= true; b36b = false;
		b37 =true; b38a = false; b38b = true;  b39 = false; b40 = false; b41 = false; b42 =true; b43 = false;
		b3_4a = false; b3_4b = false; b9_3a = false; b9_4a = false; b23_26a = false; b23_26b = false; b24_30a  =false; b24_30b = false;
		light1 = false; light2 = false; light3 = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		set_boolval();
			
	}

	void set_boolval(){
		click_obj = cr.pass_gameobject();
		if(click_obj == null){return;}

		//short1
		if(click_obj == obj3 || click_obj == obj4){
		if(obj3.transform.eulerAngles.y==90.0f && obj4.transform.eulerAngles.y==270.0f){b3_4a=true;}else{b3_4a=false;}
		if((obj3.transform.eulerAngles.y==0.0f && obj4.transform.eulerAngles.y==270.0f) ||
		 	(obj3.transform.eulerAngles.y==90.0f && obj4.transform.eulerAngles.y==0.0f) || 
			 (obj3.transform.eulerAngles.y==0.0f && obj4.transform.eulerAngles.y==0.0f)){b3_4b=true;} else{b3_4b=false;}
		}

		if(b3_4a){
			if(click_obj == obj5){
			if(obj5.transform.eulerAngles.y == 0.0f){ b5 = true; } else{b5=false;}
			}
			if(click_obj == obj6){
			if(obj6.transform.eulerAngles.y == 90.0f){ b6 = true; } else{b6=false;}
			}
			if(click_obj == obj7){
			if(obj7.transform.eulerAngles.y == 0.0f || obj7.transform.eulerAngles.y == 180.0f){ b7 = true; } else{b7=false;}
			}
			if(click_obj == obj8){
			if(obj8.transform.eulerAngles.y == 0.0f || obj8.transform.eulerAngles.y == 180.0f){ b8 = true; } else{b8=false;}
			}
			if(click_obj == obj10){
			if(obj10.transform.eulerAngles.y == 0.0f || obj10.transform.eulerAngles.y == 180.0f){ b10 = true; } else{b10=false;}
			}
			if(click_obj == obj11){
			if(obj11.transform.eulerAngles.y == 0.0f || obj11.transform.eulerAngles.y == 180.0f){ b11 = true; } else{b11=false;}
			}
			if(click_obj == obj12){
			if(obj12.transform.eulerAngles.y == 0.0f || obj12.transform.eulerAngles.y == 180.0f){ b12 = true; } else{b12=false;}
			}
			if(click_obj == obj13){
			if(obj13.transform.eulerAngles.y == 0.0f || obj13.transform.eulerAngles.y == 180.0f){ b13 = true; } else{b13=false;}
			}
			short1 = (b5&&b6) && (b7&&b8) && (b10&&b11) && (b12&&b13); 
		}
		

		//short2
		if(click_obj == obj3 || click_obj == obj9){
		if(obj3.transform.eulerAngles.y==90.0f && (obj9.transform.eulerAngles.y==270.0f || obj9.transform.eulerAngles.y==0.0f))
				{b9_3a=true;}else{b9_3a=false;}
		}		
		
		if(b9_3a){
			if(click_obj == obj6){
			if(obj6.transform.eulerAngles.y == 90.0f){ b6 = true; } else{b6=false;}
			}
			if(click_obj == obj7){
			if(obj7.transform.eulerAngles.y == 0.0f || obj7.transform.eulerAngles.y == 180.0f){ b7 = true; } else{b7=false;}
			}
			if(click_obj == obj10){
			if(obj10.transform.eulerAngles.y == 0.0f || obj10.transform.eulerAngles.y == 180.0f){ b10 = true; } else{b10=false;}
			}
			if(click_obj == obj11){
			if(obj11.transform.eulerAngles.y == 0.0f || obj11.transform.eulerAngles.y == 180.0f){ b11 = true; } else{b11=false;}
			}
			short2 = (b7&&b6) && (b10&&b11); 
		}

		//short3
		if(click_obj == obj4 || click_obj == obj9){
		if(obj4.transform.eulerAngles.y==270.0f && (obj9.transform.eulerAngles.y==270.0f || obj9.transform.eulerAngles.y==0.0f))
				{b9_4a=true;}else{b9_4a=false;}
		}
		
		if(b9_4a){
			if(click_obj == obj5){
			if(obj5.transform.eulerAngles.y == 0.0f){ b5 = true; } else{b5=false;}
			}
			if(click_obj == obj8){
			if(obj8.transform.eulerAngles.y == 0.0f || obj8.transform.eulerAngles.y == 180.0f){ b8 = true; } else{b8=false;}
			}
			if(click_obj == obj12){
			if(obj12.transform.eulerAngles.y == 0.0f || obj12.transform.eulerAngles.y == 180.0f){ b12 = true; } else{b12=false;}
			}
			if(click_obj == obj13){
			if(obj13.transform.eulerAngles.y == 0.0f || obj13.transform.eulerAngles.y == 180.0f){ b13 = true; } else{b13=false;}
			}
			short3 = (b5&&b8) && (b13&&b12); 
		}

		//short4
		if(click_obj == obj23 || click_obj == obj26){
		if(obj23.transform.eulerAngles.y==270.0f && obj26.transform.eulerAngles.y==0.0f){b23_26a=true;}else{b23_26a=false;}
		if((obj23.transform.eulerAngles.y==90.0f && obj26.transform.eulerAngles.y==0.0f) ||
		 	(obj23.transform.eulerAngles.y==270.0f && obj26.transform.eulerAngles.y==270.0f) || 
			 (obj23.transform.eulerAngles.y==90.0f && obj26.transform.eulerAngles.y==270.0f)){b23_26b=true;} else{b23_26b=false;}
		}
		if(b23_26a){
			if(click_obj == obj27){
			if(obj27.transform.eulerAngles.y == 0.0f || obj27.transform.eulerAngles.y == 180.0f){ b27 = true; } else{b27=false;}
			}
			short4 = b27;
		}

		//short5
		if(click_obj == obj24 || click_obj == obj30){
		if(obj24.transform.eulerAngles.y==90.0f && obj30.transform.eulerAngles.y==0.0f){b24_30a=true;}else{b24_30a=false;}
		if((obj24.transform.eulerAngles.y==90.0f && obj30.transform.eulerAngles.y==90.0f) ||
		 	(obj24.transform.eulerAngles.y==270.0f && obj30.transform.eulerAngles.y==0.0f) || 
			 (obj24.transform.eulerAngles.y==270.0f && obj30.transform.eulerAngles.y==90.0f)){b24_30b=true;} else{b24_30b=false;}
		}

		if(b24_30a){
			if(click_obj == obj31){
			if(obj31.transform.eulerAngles.y == 0.0f || obj31.transform.eulerAngles.y == 180.0f){ b31= true; } else{b31=false;}
			}
			short5 = b31;
		}

		short_net_a = ((b3_4a&&!short1) || b3_4b) && ((b9_3a&&!short2) || !b9_3a) && ((b9_4a&&!short3) || !b9_4a);
		short_net_b = ((b23_26a&&!short4) || b23_26b)  && ((b24_30a&&!short5) || b24_30b);
		short_net = short_net_a && short_net_b;

		
		if(click_obj == obj1){	
		if(obj1.transform.eulerAngles.y == 0.0f || obj1.transform.eulerAngles.y == 180.0f){ b1 = true; } else{b1=false;}
		}
		if(click_obj == obj2){
		if(obj2.transform.eulerAngles.y == 0.0f || obj2.transform.eulerAngles.y == 180.0f){ b2 = true; } else{b2=false;}		
		}
		if(click_obj == obj15){
		if(obj15.transform.eulerAngles.y == 270.0f || obj15.transform.eulerAngles.y == 90.0f){ b15 = true; } else{b15=false;}
		}
		if(click_obj == obj16){
		if(obj16.transform.eulerAngles.y == 90.0f || obj16.transform.eulerAngles.y == 270.0f){ b16 = true; } else{b16=false;}
		}
		if(click_obj == obj14){
		if(obj14.transform.eulerAngles.y == 270.0f || obj14.transform.eulerAngles.y == 90.0f){ b14 = true; } else{b14=false;}
		}
		if(click_obj == obj17){
		if(obj17.transform.eulerAngles.y == 90.0f || obj17.transform.eulerAngles.y == 270.0f){ b17 = true; } else{b17=false;}
		}
		if(click_obj == obj18){
		if(obj18.transform.eulerAngles.y == 90.0f || obj18.transform.eulerAngles.y == 270.0f){ b18 = true; } else{b18=false;}
		}
		if(click_obj == obj19){
		if(obj19.transform.eulerAngles.y == 90.0f || obj19.transform.eulerAngles.y == 270.0f){ b19 = true; } else{b19=false;}
		}
		if(click_obj == obj20){
		if(obj20.transform.eulerAngles.y == 90.0f || obj20.transform.eulerAngles.y == 270.0f){ b20 = true; } else{b20=false;}
		}
		if(click_obj == obj21){
		if(obj21.transform.eulerAngles.y == 270.0f || obj21.transform.eulerAngles.y == 90.0f){ b21 = true; } else{b21=false;}
		}
		if(click_obj == obj22){
		if(obj22.transform.eulerAngles.y == 270.0f || obj22.transform.eulerAngles.y == 90.0f){ b22 = true; } else{b22=false;}		
		}
		if(click_obj == obj28){
		if(obj28.transform.eulerAngles.y == 0.0f || obj28.transform.eulerAngles.y == 180.0f){ b28 = true; } else{b28=false;}
		}
		if(click_obj == obj29){
		if(obj29.transform.eulerAngles.y == 0.0f || obj29.transform.eulerAngles.y == 180.0f){ b29 = true; } else{b29=false;}
		}


		a1 = (b1&&b2) && (b19&&b18) && (b17&&b14) && (b15&&b16) && (b20&&b21) && (b22) && (b28&&b29);	
		

		
		if(click_obj == obj25){
		if(obj25.transform.eulerAngles.y == 270.0f || obj25.transform.eulerAngles.y == 90.0f){ b25 = true; } else{b25=false;}
		}
		if(click_obj == obj33){
		if(obj33.transform.eulerAngles.y == 0.0f || obj33.transform.eulerAngles.y == 180.0f){ b33 = true; } else{b33=false;}
		}
		if(click_obj == obj37){
		if(obj37.transform.eulerAngles.y == 0.0f || obj37.transform.eulerAngles.y == 180.0f){ b37 = true; } else{b37=false;}
		}
		if(click_obj == obj39){
		if(obj39.transform.eulerAngles.y == 270.0f || obj39.transform.eulerAngles.y == 90.0f){ b39= true; } else{b39=false;}
		}
		if(click_obj == obj40){
		if(obj40.transform.eulerAngles.y == 180.0f){ b40 = true; } else{b40=false;}
		}
		if(click_obj == obj41){
		if(obj41.transform.eulerAngles.y == 270.0f || obj41.transform.eulerAngles.y == 90.0f){ b41= true; } else{b41=false;}
		}
		if(click_obj == obj42){
		if(obj42.transform.eulerAngles.y == 270.0f || obj42.transform.eulerAngles.y == 90.0f){ b42= true; } else{b42=false;}
		}
		if(click_obj == obj43){
		if(obj43.transform.eulerAngles.y == 270.0f){ b43 = true; } else{b43=false;}
		}
		
		a2 = (b25&&b42) && (b33&&b43);
		a3 = (b39&&b41) && (b40&&b37);

		
		if(click_obj == obj32){
		if(obj32.transform.eulerAngles.y == 180.0f){ b32a = true; } else{b32a=false;}
		if(obj32.transform.eulerAngles.y == 0.0f){ b32b = true; } else{b32b=false;}
		}

		if(click_obj == obj38){
		if(obj38.transform.eulerAngles.y == 180.0f){ b38a = true; } else{b38a=false;}
		if(obj38.transform.eulerAngles.y == 0.0f){ b38b = true; } else{b38b=false;}
		}

		if(click_obj == obj36){
		if(obj36.transform.eulerAngles.y == 180.0f){ b36a = true; } else{b36a=false;}
		if(obj36.transform.eulerAngles.y == 0.0f){ b36b = true; } else{b36b=false;}
		}

		if(click_obj == obj34){
		if(obj34.transform.eulerAngles.y == 0.0f || obj34.transform.eulerAngles.y == 180.0f){ b34 = true; } else{b34=false;}
		}
		if(click_obj == obj35){
		if(obj35.transform.eulerAngles.y == 0.0f || obj35.transform.eulerAngles.y == 180.0f){ b35 = true; } else{b35=false;}
		}

		if(click_obj == l1){
		if(l1.transform.eulerAngles.y == 90.0f || l1.transform.eulerAngles.y == 270.0f){ light1 = true; } else{light1=false;}
		}
		if(click_obj == l2){
		if(l2.transform.eulerAngles.y == 90.0f || l2.transform.eulerAngles.y == 270.0f){ light2 = true; } else{light2=false;}
		}
		if(click_obj == l3){
		if(l3.transform.eulerAngles.y == 90.0f || l3.transform.eulerAngles.y == 270.0f){ light3 = true; } else{light3=false;}
		}

		if(a1&&short_net){
			if(a2 && b32a && b34 && (b38a || b38b) && b35 && (b36a ||b36b) && a3 & light1){
				lit_bulb = true;
			}else{
				lit_bulb = false;
			}

			if(a2 && (b32a || b32b) && b34 && (b38a || b38b) && b35 && (b36a) && a3 &&light3){
				lit_bulb3 = true;
			}else{
				lit_bulb3 = false;
			}

			if((lit_bulb||lit_bulb3) && b34 && b35 && b38a &&light2){
				lit_bulb2 = true;
			}else{
				lit_bulb2= false;
			}
		}else{
			lit_bulb = false;
			lit_bulb2= false;
			lit_bulb3 =false;
		}


	}

	public bool[] pass_bool(){
		bool[] arr = {lit_bulb,lit_bulb2,lit_bulb3};
		return arr;
	}
}
