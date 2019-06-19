using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit1_7 : MonoBehaviour {

	public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10 , obj11, obj12, obj15, obj13, obj14, obj16,
			obj17, obj18, obj19, obj20, obj21, obj22, obj23, obj24, obj25, obj26, obj27, obj28, obj29, obj30, obj31, 
			obj32, obj33, obj34, obj35, obj36, obj37, obj38, obj39, obj40 , obj41, obj42, obj43, obj44, obj45, obj46,
			obj47, obj48, obj49, obj50, obj51 ;

	public GameObject l1;

	change_rot cr;
	GameObject click_obj;

	bool b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11,b12_15a,b12_15b,b14,b16,b18_20a,b18_20b,b19,b21,b22,b23_31a,b23_31b,b24_34a,b24_34b
	,b25,b26,b27,b28,b29,b30,b35,b36,b37,b38,b39,b40,b41,b42,b43,b44,b45,b46,b47,b48,b49,b50,b51;
	bool short1, short2, short3, short4, a1, a2, a, x, light1;
	public bool lit_bulb;

	#region Singleton
	public static circuit1_7 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
		b1 = false;	b2 = false; b3 = true; b4 = false; b5 = false; b6 = false; b7 = false; b8 = false; b9 = false; b10 = false;
		b11 = false; b12_15a = false; b12_15b = false; short1 = true; b14 = true;  b16 = true; short2 = false; b18_20a = false; b18_20b =false;
		b19 = false; b21 = false; b22 = false; b23_31a = false; b23_31b = false; b24_34a = false; b24_34b = false; b25 = true; b26 = false;
		b27 = true; b28 = false; b29 = true; b30 = false; short3 = true; short4 = true; b35 = false; b36 = false; b37 = true; b38 = false;
		b39 = false; b40 = true; b41 = false; b42 = false; b43 = false; b44 = false; b45 = false; b46 = false; b47 = false; b48 = false;
		b49 = true; b50 = false; b51 = true;
		light1 = false; 

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
		if(obj3.transform.eulerAngles.y == 0.0f || obj3.transform.eulerAngles.y == 90.0f){ b3 = true; } else{b3=false;}
		}
		if(click_obj == obj4){
		if(obj4.transform.eulerAngles.y == 0.0f || obj4.transform.eulerAngles.y == 270.0f){ b4 = true; } else{b4=false;}
		}
		if(click_obj == obj5){
		if(obj5.transform.eulerAngles.y == 90.0f || obj5.transform.eulerAngles.y == 270.0f){ b5 = true; } else{b5=false;}
		}
		if(click_obj == obj6){
		if(obj6.transform.eulerAngles.y == 90.0f || obj6.transform.eulerAngles.y == 270.0f){ b6 = true; } else{b6=false;}
		}
		if(click_obj == obj7){
		if(obj7.transform.eulerAngles.y == 90.0f || obj7.transform.eulerAngles.y == 180.0f){ b7 = true; } else{b7=false;}
		}
		if(click_obj == obj8){
		if(obj8.transform.eulerAngles.y == 180.0f || obj8.transform.eulerAngles.y == 270.0f){ b8 = true; } else{b8=false;}
		}
		if(click_obj == obj9){
		if(obj9.transform.eulerAngles.y == 0.0f || obj9.transform.eulerAngles.y == 90.0f){ b9 = true; } else{b9=false;}
		}
		if(click_obj == obj10){
		if(obj10.transform.eulerAngles.y == 0.0f || obj10.transform.eulerAngles.y == 270.0f){ b10 = true; } else{b10=false;}
		}
		if(click_obj == obj11){
		if(obj11.transform.eulerAngles.y == 90.0f || obj11.transform.eulerAngles.y == 270.0f){ b11 = true; } else{b11=false;}
		}
		if(click_obj == obj14){
		if(obj14.transform.eulerAngles.y == 0.0f || obj14.transform.eulerAngles.y == 180.0f){ b14 = true; } else{b14=false;}
		}
		if(click_obj == obj16){
		if(obj16.transform.eulerAngles.y == 0.0f || obj16.transform.eulerAngles.y == 180.0f){ b16 = true; } else{b16=false;}
		}
		if(click_obj == obj19){
		if(obj19.transform.eulerAngles.y == 90.0f || obj19.transform.eulerAngles.y == 270.0f){ b19 = true; } else{b19=false;}
		}
		if(click_obj == obj21){
		if(obj21.transform.eulerAngles.y == 90.0f || obj21.transform.eulerAngles.y == 270.0f){ b21 = true; } else{b21=false;}
		}
		if(click_obj == obj22){
		if(obj22.transform.eulerAngles.y == 90.0f || obj22.transform.eulerAngles.y == 270.0f){ b22 = true; } else{b22=false;}
		}
		if(click_obj == obj25){
		if(obj25.transform.eulerAngles.y == 0.0f || obj25.transform.eulerAngles.y == 180.0f){ b25 = true; } else{b25=false;}
		}
		if(click_obj == obj26){
		if(obj26.transform.eulerAngles.y == 0.0f ){ b26 = true; } else{b26=false;}
		}
		if(click_obj == obj27){
		if(obj27.transform.eulerAngles.y == 0.0f || obj27.transform.eulerAngles.y == 180.0f){ b27 = true; } else{b27=false;}
		}
		if(click_obj == obj28){
		if(obj28.transform.eulerAngles.y == 0.0f || obj28.transform.eulerAngles.y == 180.0f){ b28 = true; } else{b28=false;}
		}
		if(click_obj == obj29){
		if(obj29.transform.eulerAngles.y == 0.0f || obj29.transform.eulerAngles.y == 180.0f){ b29 = true; } else{b29=false;}
		}
		if(click_obj == obj30){
		if(obj30.transform.eulerAngles.y == 90.0f || obj30.transform.eulerAngles.y == 270.0f){ b30 = true; } else{b30=false;}
		}
		if(click_obj == obj35){
		if(obj35.transform.eulerAngles.y == 90.0f || obj35.transform.eulerAngles.y == 270.0f){ b35 = true; } else{b35=false;}
		}
		if(click_obj == obj36){
		if(obj36.transform.eulerAngles.y == 90.0f || obj36.transform.eulerAngles.y == 270.0f){ b36 = true; } else{b36=false;}
		}
		if(click_obj == obj37){
		if(obj37.transform.eulerAngles.y == 90.0f || obj37.transform.eulerAngles.y == 270.0f){ b37 = true; } else{b37=false;}
		}
		if(click_obj == obj38){
		if(obj38.transform.eulerAngles.y == 90.0f || obj38.transform.eulerAngles.y == 270.0f){ b38 = true; } else{b38=false;}
		}
		if(click_obj == obj39){
		if(obj39.transform.eulerAngles.y == 90.0f || obj39.transform.eulerAngles.y == 270.0f){ b39 = true; } else{b39=false;}
		}
		if(click_obj == obj40){
		if(obj40.transform.eulerAngles.y == 90.0f || obj40.transform.eulerAngles.y == 270.0f){ b40 = true; } else{b40=false;}
		}
		if(click_obj == obj41){
		if(obj41.transform.eulerAngles.y == 180.0f ){ b41 = true; } else{b41=false;}
		}
		if(click_obj == obj42){
		if(obj42.transform.eulerAngles.y == 0.0f || obj42.transform.eulerAngles.y == 180.0f){ b42 = true; } else{b42=false;}
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
		if(obj47.transform.eulerAngles.y == 270.0f ){ b47 = true; } else{b47=false;}
		}
		if(click_obj == obj48){
		if(obj48.transform.eulerAngles.y == 90.0f || obj48.transform.eulerAngles.y == 270.0f){ b48 = true; } else{b48=false;}
		}
		if(click_obj == obj49){
		if(obj49.transform.eulerAngles.y == 0.0f || obj49.transform.eulerAngles.y == 180.0f){ b49 = true; } else{b49=false;}
		}
		if(click_obj == obj50){
		if(obj50.transform.eulerAngles.y == 180.0f ){ b50 = true; } else{b50=false;}
		}
		if(click_obj == obj51){
		if(obj51.transform.eulerAngles.y == 90.0f || obj51.transform.eulerAngles.y == 270.0f){ b51 = true; } else{b51=false;}
		}

		
		if(click_obj == obj12 || click_obj == obj15){
		if(obj12.transform.eulerAngles.y == 270.0f && obj15.transform.eulerAngles.y == 0.0f){ b12_15a = true; } else{b12_15a=false;}
		if((obj12.transform.eulerAngles.y == 90.0f && obj15.transform.eulerAngles.y == 0.0f) || 
			(obj12.transform.eulerAngles.y == 90.0f && obj15.transform.eulerAngles.y == 270.0f)|| 
			(obj12.transform.eulerAngles.y == 270.0f && obj15.transform.eulerAngles.y == 270.0f))
		{ b12_15b = true; } else{b12_15b=false;}
		}


		if(click_obj == obj18 || click_obj == obj20){
		if(obj18.transform.eulerAngles.y == 0.0f && obj20.transform.eulerAngles.y == 90.0f){ b18_20a = true; } else{b18_20a=false;}
		if((obj18.transform.eulerAngles.y == 90.0f && obj20.transform.eulerAngles.y == 90.0f) || 
			(obj18.transform.eulerAngles.y == 90.0f && obj20.transform.eulerAngles.y == 270.0f)|| 
			(obj18.transform.eulerAngles.y == 0.0f && obj20.transform.eulerAngles.y == 270.0f))
		{ b18_20b = true; } else{b18_20b=false;}
		}


		if(click_obj == obj23 || click_obj == obj31){
		if(obj23.transform.eulerAngles.y == 180.0f && obj31.transform.eulerAngles.y == 270.0f){ b23_31a = true; } else{b23_31a=false;}
		if((obj23.transform.eulerAngles.y == 270.0f && obj31.transform.eulerAngles.y ==270.0f) || 
			(obj23.transform.eulerAngles.y == 180.0f && obj31.transform.eulerAngles.y == 90.0f)|| 
			(obj23.transform.eulerAngles.y == 270.0f && obj31.transform.eulerAngles.y == 90.0f))
		{ b23_31b = true; } else{b23_31b=false;}
		}


		if(click_obj == obj24 || click_obj == obj34){
		if(obj24.transform.eulerAngles.y == 180.0f && obj34.transform.eulerAngles.y == 90.0f){ b24_34a = true; } else{b24_34a=false;}
		if((obj24.transform.eulerAngles.y == 180.0f && obj34.transform.eulerAngles.y ==270.0f) || 
			(obj24.transform.eulerAngles.y == 90.0f && obj34.transform.eulerAngles.y == 270.0f)|| 
			(obj24.transform.eulerAngles.y == 90.0f && obj34.transform.eulerAngles.y == 90.0f))
		{ b24_34b = true; } else{b24_34b=false;}
		}


		if(b12_15a){
		if(obj13.transform.eulerAngles.y == 0.0f || obj13.transform.eulerAngles.y == 180.0f){ short1 = true; } else{short1=false;}
		}
		if(b18_20a){
		if(obj17.transform.eulerAngles.y == 0.0f || obj17.transform.eulerAngles.y == 180.0f){ short2 = true; } else{short2=false;}
		}
		if(b23_31a){
		if(obj32.transform.eulerAngles.y == 0.0f || obj32.transform.eulerAngles.y == 180.0f){ short3 = true; } else{short3=false;}
		}
		if(b24_34a){
		if(obj33.transform.eulerAngles.y == 0.0f || obj33.transform.eulerAngles.y == 180.0f){ short4 = true; } else{short4=false;}
		}


		if(click_obj == l1){
		if(l1.transform.eulerAngles.y == 90.0f || l1.transform.eulerAngles.y == 270.0f){ light1 = true; } else{light1=false;}
		}



		a1 = (b1&&b2) && (b3&&b4) && (b5&&b6) && (b7&&b8) && (b9&&b10) && (b11&&b14) && (b16&&b19) && (b21&&b22) && (b25&&b26) && (b27&&b28);
		a2 = (b29&&b30) && (b36&&b35) && (b37&&b38) && (b39&&b40) && (b41&&b42) && (b43&&b44) && (b45&&b46) && (b47&&b48) && (b49&&b50) && b51;
		a = a1 && a2;

		Debug.Log(a1 + " " + a2);

		if(a && light1){
			
			if( (b12_15b || (b12_15a&&!short1)) &&  (b18_20b || (b18_20a && !short2)) &&
			 (b24_34b || (b24_34a || !short4))&&(b23_31b || (b23_31a && !short3)) ){
				lit_bulb = true;
			}else{
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
