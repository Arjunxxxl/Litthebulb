﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit3_6 : MonoBehaviour {

		public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16, obj17, obj18, obj19, obj20
					, obj21, obj22, obj23, obj24, obj25, obj26, obj27, obj28, obj29, obj30,
					obj31, obj32, obj33, obj34, obj35, obj36, obj37, obj38;

	public GameObject trans;

	
	change_rot cr;
	GameObject click_obj;
	
	public bool a,b, transform, c;
	public bool short1;

	bool b1,b2,b3,b4,b5,b6,b7,b8,b9,b10_13a,b10_13b,b11,b12,b14,b15,b16,b17,b18,b19,b20,b21,b22,b23,b24,b25,b26,b27,b28,b29,b30,
		b31,b32,b33,b34,b35,b36,b37,b38;
	
	
	#region Singleton
	public static circuit3_6 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
		b1=b2=b3=b4=b5=b6=b7=b8=b9=b11=b15=b16=b17=b18=b19=b20=b21=b22=b23=b24=b25=b26=b27=b28=b29=b30=
		b31=b32=b33=b34=b35=b36=b37=false;
		b10_13b= false;
		b10_13a=b12=b14=b38=true;
	}
	
	
	// Update is called once per frame
	void Update () {
		click_obj = cr.pass_gameobject();
		if(click_obj ==null){return;}
		//Debug.Log(click_obj.transform.eulerAngles.y);

		if(click_obj == obj1){
			if(obj1.transform.eulerAngles.y == 270f || obj1.transform.eulerAngles.y == 180f){b1 = true;}else{b1 = false;}
		}
		if(click_obj == obj3){
			if(obj3.transform.eulerAngles.y == 0f || obj3.transform.eulerAngles.y == 180f){b3 = true;}else{b3 = false;}
		}
		if(click_obj == obj4){
			if(obj4.transform.eulerAngles.y == 0f || obj4.transform.eulerAngles.y == 180f){b4 = true;}else{b4 = false;}
		}
		if(click_obj == obj18){
			if(obj18.transform.eulerAngles.y == 0f){b18 = true;}else{b18 = false;}
		}
		if(click_obj == obj16){
			if(obj16.transform.eulerAngles.y == 180f){b16 = true;}else{b16 = false;}
		}
		if(click_obj == obj19){
			if(obj19.transform.eulerAngles.y == 90f){b19 = true;}else{b19 = false;}
		}
		if(click_obj == obj17){
			if(obj17.transform.eulerAngles.y == 0f){b17 = true;}else{b17 = false;}
		}
		if(click_obj == obj5){
			if(obj5.transform.eulerAngles.y == 270f || obj5.transform.eulerAngles.y == 180f){b5 = true;}else{b5 = false;}
		}
		if(click_obj == obj23){
			if(obj23.transform.eulerAngles.y == 90f){b23 = true;}else{b23 = false;}
		}
		if(click_obj == obj24){
			if(obj24.transform.eulerAngles.y == 180f){b24 = true;}else{b24 = false;}
		}
		if(click_obj == obj25){
			if(obj25.transform.eulerAngles.y == 0f){b25 = true;}else{b25 = false;}
		}
		if(click_obj == obj27){
			if(obj27.transform.eulerAngles.y == 270f){b27 = true;}else{b27 = false;}
		}
		if(click_obj == obj30){
			if(obj30.transform.eulerAngles.y == 180f){b30 = true;}else{b30 = false;}
		}
		if(click_obj == obj29){
			if(obj29.transform.eulerAngles.y == 90f){b29 = true;}else{b29 = false;}
		}

		a = (b1 && b3) && (b4 && b5) && (b17 && b16) && (b18 && b19) && (b24 && b23) && (b25 && b27) && (b29&& b30);

		if(click_obj == obj2){
			if(obj2.transform.eulerAngles.y == 0f || obj2.transform.eulerAngles.y == 270f){b2 = true;}else{b2 = false;}
		}
		if(click_obj == obj20){
			if(obj20.transform.eulerAngles.y == 270f){b20 = true;}else{b20 = false;}
		}
		if(click_obj == obj6){
			if(obj6.transform.eulerAngles.y == 0f || obj6.transform.eulerAngles.y == 180f){b6 = true;}else{b6 = false;}
		}
		if(click_obj == obj7){
			if(obj7.transform.eulerAngles.y == 0f || obj7.transform.eulerAngles.y == 180f){b7 = true;}else{b7 = false;}
		}
		if(click_obj == obj21){
			if(obj21.transform.eulerAngles.y == 180f){b21 = true;}else{b21 = false;}
		}
		if(click_obj == obj22){
			if(obj22.transform.eulerAngles.y == 90f){b22 = true;}else{b22 = false;}
		}

		b = (b2 && b20) && (b6 && b7) && (b21 && b22);

		if(click_obj == obj26){
			if(obj26.transform.eulerAngles.y == 270f){b26 = true;}else{b26 = false;}
		}
		if(click_obj == obj28){
			if(obj28.transform.eulerAngles.y == 0f){b28 = true;}else{b28 = false;}
		}
		if(click_obj == obj8){
			if(obj8.transform.eulerAngles.y == 0f || obj8.transform.eulerAngles.y == 180f){b8 = true;}else{b8 = false;}
		}
		if(click_obj == obj9){
			if(obj9.transform.eulerAngles.y == 0f || obj9.transform.eulerAngles.y == 180f){b9 = true;}else{b9 = false;}
		}
		if(click_obj == obj11){
			if(obj11.transform.eulerAngles.y == 90f || obj11.transform.eulerAngles.y == 270f){b11 = true;}else{b11 = false;}
		}
		if(click_obj == obj33){
			if(obj33.transform.eulerAngles.y == 0f || obj33.transform.eulerAngles.y == 270f){b33 = true;}else{b33 = false;}
		}
		if(click_obj == obj15){
			if(obj15.transform.eulerAngles.y == 90f || obj15.transform.eulerAngles.y == 180f){b15 = true;}else{b15 = false;}
		}
		if(click_obj == obj32){
			if(obj32.transform.eulerAngles.y == 0f || obj32.transform.eulerAngles.y == 270f){b32 = true;}else{b32 = false;}
		}
		if(click_obj == obj34){
			if(obj34.transform.eulerAngles.y == 0f || obj34.transform.eulerAngles.y == 180f){b34 = true;}else{b34 = false;}
		}
		if(click_obj == obj35){
			if(obj35.transform.eulerAngles.y == 0f || obj35.transform.eulerAngles.y == 90f){b35 = true;}else{b35 = false;}
		}
		if(click_obj == obj31){
			if(obj31.transform.eulerAngles.y == 90f || obj31.transform.eulerAngles.y == 180f){b31 = true;}else{b31 = false;}
		}
		if(click_obj == obj36){
			if(obj36.transform.eulerAngles.y == 90f || obj36.transform.eulerAngles.y == 270f){b36 = true;}else{b36 = false;}
		}
		if(click_obj == obj37){
			if(obj37.transform.eulerAngles.y == 90f || obj37.transform.eulerAngles.y == 270f){b37 = true;}else{b37 = false;}
		}
		if(click_obj == obj38){
			if(obj38.transform.eulerAngles.y == 90f || obj38.transform.eulerAngles.y == 270f){b38 = true;}else{b38 = false;}
		}

		c = (b26 && b28) && (b8 && b9) && (b11 && b33) && (b15 && b32) && (b34 && b35) && (b31 && b36) && (b37 && b38);

		if(click_obj == obj12){
			if(obj12.transform.eulerAngles.y == 90f || obj12.transform.eulerAngles.y == 270f){b12 = true;}else{b12 = false;}
		}
		if(click_obj == obj14){
			if(obj14.transform.eulerAngles.y == 90f || obj14.transform.eulerAngles.y == 270f){b14 = true;}else{b14 = false;}
		}
		short1 = b12 && b14;

		if(click_obj == obj10 || click_obj == obj13){
			if(obj10.transform.eulerAngles.y == 90f && obj13.transform.eulerAngles.y == 180f){b10_13a = true;}else{b10_13a = false;}
			
			if((obj10.transform.eulerAngles.y == 90f && obj13.transform.eulerAngles.y == 0f) || 
				(obj10.transform.eulerAngles.y == 180f && obj13.transform.eulerAngles.y == 180f) ||
				 (obj10.transform.eulerAngles.y == 180f && obj13.transform.eulerAngles.y == 0f)){b10_13b = true;}else{b10_13b = false;}
		}

		if(click_obj == trans){
			if(trans.transform.eulerAngles.y == 180f){transform = true;}else{transform = false;}
		}

	}

	public bool[] pass_bool1()
	{		
		bool[] bo = {a,b, transform, c, short1, b10_13a, b10_13b} ;
			return bo;
	}

}
