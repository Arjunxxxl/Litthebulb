using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit2_1 : MonoBehaviour {

	public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16, obj17, obj18, obj19, obj20
					, obj21, obj22, obj23, obj24, obj25, obj26, obj27, obj28, obj29, obj30,obj31, obj32, obj33, obj34;

	
	change_rot cr;
	GameObject click_obj;


	bool b1,b2,b3,b4,b5_6a,b5_6b,b7,b8,b9,b10,b11,b12,b13,b14,b15,b16,b17,b18,b19,b20,b21,b22,b23,b24,b25,b26,b27,b28,b29,b30,b31,b32,b33,b34;
	public bool short1, a, b;
	
	#region Singleton
	public static circuit2_1 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
		b1=b2=b3=b4=b5_6a=b5_6b=b8=b9=b10=b11=b13=b14=b17=b18=b19=b20=b22=b23=b24=b25=b26=b27=b28=b29=b30=b32=b33=false;
		b12 = b7= b15=b16=b21=b31=b34=true;
	}
	
	// Update is called once per frame
	void Update () {
		click_obj = cr.pass_gameobject();
		if(click_obj ==null){return;}

		if(click_obj == obj5 || click_obj == obj6){
			if(obj5.transform.eulerAngles.y == 180f && obj6.transform.eulerAngles.y == 180f){b5_6a = true;}else{b5_6a = false;}
			if((obj5.transform.eulerAngles.y == 180f && obj6.transform.eulerAngles.y == 270f) 
					|| (obj5.transform.eulerAngles.y == 90f && obj6.transform.eulerAngles.y == 180f) || 
					(obj5.transform.eulerAngles.y == 90f && obj6.transform.eulerAngles.y == 270f)) {b5_6b = true;}else{b5_6b = false;}
		}

		if(click_obj == obj11){
			if(obj11.transform.eulerAngles.y == 0f || obj11.transform.eulerAngles.y == 180f){b11 = true;}else{b11 = false;}
		}
		if(click_obj == obj12){
			if(obj12.transform.eulerAngles.y == 0f || obj12.transform.eulerAngles.y == 180f){b12 = true;}else{b12 = false;}
		}

		short1 = b11 && b12;

		

		
		if(click_obj == obj1){
			if(obj1.transform.eulerAngles.y == 0f || obj1.transform.eulerAngles.y == 270f){b1 = true;}else{b1 = false;}
		}
		if(click_obj == obj2){
			if(obj2.transform.eulerAngles.y == 0f || obj2.transform.eulerAngles.y == 90f){b2 = true;}else{b2 = false;}
		}
		if(click_obj == obj3){
			if(obj3.transform.eulerAngles.y == 90f || obj3.transform.eulerAngles.y == 270f){b3 = true;}else{b3 = false;}
		}

		if(click_obj == obj4){
			if(obj4.transform.eulerAngles.y == 90f || obj4.transform.eulerAngles.y == 270f){b4 = true;}else{b4 = false;}
		}
		if(click_obj == obj7){
			if(obj7.transform.eulerAngles.y == 0f || obj7.transform.eulerAngles.y == 180f){b7 = true;}else{b7 = false;}
		}
		if(click_obj == obj8){
			if(obj8.transform.eulerAngles.y == 0f || obj8.transform.eulerAngles.y == 180f){b8 = true;}else{b8 = false;}
		}

		if(click_obj == obj9){
			if(obj9.transform.eulerAngles.y == 0f){b9 = true;}else{b9 = false;}
		}
		if(click_obj == obj10){
			if(obj10.transform.eulerAngles.y == 90f){b10 = true;}else{b10 = false;}
		}
		if(click_obj == obj13){
			if(obj13.transform.eulerAngles.y == 90f || obj13.transform.eulerAngles.y == 270f){b13 = true;}else{b13 = false;}
		}
		if(click_obj == obj14){
			if(obj14.transform.eulerAngles.y == 90f || obj14.transform.eulerAngles.y == 270f){b14 = true;}else{b14 = false;}
		}
		if(click_obj == obj15){
			if(obj15.transform.eulerAngles.y == 90f || obj15.transform.eulerAngles.y == 270f){b15 = true;}else{b15 = false;}
		}
		if(click_obj == obj16){
			if(obj16.transform.eulerAngles.y == 90f || obj16.transform.eulerAngles.y == 270f){b16 = true;}else{b16 = false;}
		}
		if(click_obj == obj17){
			if(obj17.transform.eulerAngles.y == 270f){b17 = true;}else{b17 = false;}
		}
		if(click_obj == obj18){
			if(obj18.transform.eulerAngles.y == 180f){b18 = true;}else{b18 = false;}
		}
		if(click_obj == obj19){
			if(obj19.transform.eulerAngles.y == 0f || obj19.transform.eulerAngles.y == 180f){b19 = true;}else{b19 = false;}
		}
		if(click_obj == obj20){
			if(obj20.transform.eulerAngles.y == 0f || obj20.transform.eulerAngles.y == 180f){b20 = true;}else{b20 = false;}
		}
		if(click_obj == obj21){
			if(obj21.transform.eulerAngles.y == 0f || obj21.transform.eulerAngles.y == 180f){b21 = true;}else{b21 = false;}
		}
		if(click_obj == obj22){
			if(obj22.transform.eulerAngles.y == 0f || obj22.transform.eulerAngles.y == 180f){b22 = true;}else{b22 = false;}
		}


		if(click_obj == obj23){
			if(obj23.transform.eulerAngles.y == 0f || obj23.transform.eulerAngles.y == 180f){b23 = true;}else{b23 = false;}
		}
		if(click_obj == obj24){
			if(obj24.transform.eulerAngles.y == 0f || obj24.transform.eulerAngles.y == 180f){b24 = true;}else{b24 = false;}
		}
		if(click_obj == obj25){
			if(obj25.transform.eulerAngles.y == 90f){b25 = true;}else{b25 = false;}
		}
		if(click_obj == obj26){
			if(obj26.transform.eulerAngles.y == 0f){b26 = true;}else{b26 = false;}
		}
		if(click_obj == obj27){
			if(obj27.transform.eulerAngles.y == 180f){b27 = true;}else{b27 = false;}
		}
		if(click_obj == obj28){
			if(obj28.transform.eulerAngles.y == 270f){b28 = true;}else{b28 = false;}
		}
		if(click_obj == obj29){
			if(obj29.transform.eulerAngles.y == 0f || obj29.transform.eulerAngles.y == 180f){b29 = true;}else{b29 = false;}
		}
		if(click_obj == obj30){
			if(obj30.transform.eulerAngles.y == 0f || obj30.transform.eulerAngles.y == 180f){b30 = true;}else{b30 = false;}
		}
		if(click_obj == obj31){
			if(obj31.transform.eulerAngles.y == 0f || obj31.transform.eulerAngles.y == 180f){b31 = true;}else{b31 = false;}
		}
		if(click_obj == obj32){
			if(obj32.transform.eulerAngles.y == 0f || obj32.transform.eulerAngles.y == 180f){b32 = true;}else{b32 = false;}
		}
		if(click_obj == obj33){
			if(obj33.transform.eulerAngles.y == 0f || obj33.transform.eulerAngles.y == 180f){b33 = true;}else{b33 = false;}
		}
		if(click_obj == obj34){
			if(obj34.transform.eulerAngles.y == 0f || obj34.transform.eulerAngles.y == 180f){b34 = true;}else{b34 = false;}
		}

		a = (b1 && b2) && (b3 && b4) && (b7 && b8) &&  (b9 && b10) &&  (b13 && b14)&& 
			 (b15 && b16)&&  (b17 && b18) &&  (b19 && b20)&&  (b21 && b22);

		b = (b23 && b24) && (b25 && b26) && (b27 && b28) &&  (b29 && b30) && (b31 && b32)&&  (b33 && b34); 

	}


	public bool[] pass_bool1()
	{		bool[] bo = {a, ((b5_6a && !short1) || b5_6b ), b} ;
			return bo;
	}
}
