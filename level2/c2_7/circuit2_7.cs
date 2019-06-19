using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit2_7 : MonoBehaviour {

	public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16, obj17, obj18, obj19, obj20
					, obj21, obj22, obj23, obj24, obj25, obj26, obj27, obj28, obj29, obj30,obj31, obj32, obj33, obj34, obj35, obj36, obj37, obj38, obj39, obj40,
					obj41, obj42, obj43, obj44, obj45, obj46, obj47, obj48, obj49, obj50,
					obj51, obj52, obj53, obj54, obj55, obj56, obj57, obj58, obj59, obj60,obj61, obj62, obj63, obj64, obj65, obj66, obj67, obj68;

	bool b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11,b12,b13,b14,b15,b16,b17,b18,b19,b20,b21,b22,b23,b24,b25,b26,b27,b28,b29,b30,b31,b32,b33,b34,b35,b36,b37,b38,b39,b40,
		b41,b42,b43,b44,b45,b46,b47,b48,b49,b50,b51,b52,b53,b54,b55,b56,b57,b58,b59,b60,b61,b62,b63,b64,b65,b66,b67,b68;
	public bool a, b, c, d, e;

	change_rot cr;
	GameObject click_obj;

	#region Singleton
	public static circuit2_7 Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
		b1=b2=b3=b4=b5=b6=b7=b8=b9=b10=b11=b12=b13=b14=b15=b16=b17=b18=b19=b20=b22=b23=b24=b25=b26=b27=b28=b29=b30=b31=b32=b35=b36=b37=b38=b39=b40=false;
		b41=b42=b43=b44=b45=b46=b47=b48=b49=b50=b51=b52=b53=b54=b59=b60=b61=b62=b63=b64=false;
		b21=b33=b34=b55=b56=b57=b58=b65=b66=b67=b68=true;
	}

	
	// Update is called once per frame
	void Update () {
		click_obj = cr.pass_gameobject();
		if(click_obj ==null){return;}
		//Debug.Log(click_obj.transform.eulerAngles.y);

		if(click_obj == obj1){
			if(obj1.transform.eulerAngles.y == 0f || obj1.transform.eulerAngles.y == 180f){b1 = true;}else{b1 = false;}
		}
		if(click_obj == obj2){
			if(obj2.transform.eulerAngles.y == 0f || obj2.transform.eulerAngles.y == 180f){b2 = true;}else{b2 = false;}
		}
		if(click_obj == obj3){
			if(obj3.transform.eulerAngles.y == 0f){b3 = true;}else{b3 = false;}
		}
		if(click_obj == obj4){
			if(obj4.transform.eulerAngles.y == 90f){b4 = true;}else{b4 = false;}
		}
		if(click_obj == obj5){
			if(obj5.transform.eulerAngles.y == 90f || obj5.transform.eulerAngles.y == 270f){b5 = true;}else{b5 = false;}
		}
		if(click_obj == obj6){
			if(obj6.transform.eulerAngles.y == 90f || obj6.transform.eulerAngles.y == 270f){b6 = true;}else{b6 = false;}
		}
		if(click_obj == obj7){
			if(obj7.transform.eulerAngles.y == 270f){b7 = true;}else{b7 = false;}
		}
		if(click_obj == obj8){
			if(obj8.transform.eulerAngles.y == 180f){b8 = true;}else{b8 = false;}
		}
		if(click_obj == obj9){
			if(obj9.transform.eulerAngles.y == 0f || obj9.transform.eulerAngles.y == 180f){b9 = true;}else{b9 = false;}
		}
		if(click_obj == obj10){
			if(obj10.transform.eulerAngles.y == 0f || obj10.transform.eulerAngles.y == 180f){b10 = true;}else{b10 = false;}
		}
		a = (b1 && b2) && (b3 && b4) && (b5 && b6) && (b7 && b8) && (b9 && b10);

		//////////////////////////////////////////////////////////////////////////////////////////////

		if(click_obj == obj11){
			if(obj11.transform.eulerAngles.y == 0f || obj11.transform.eulerAngles.y == 180f){b11 = true;}else{b11 = false;}
		}
		if(click_obj == obj12){
			if(obj12.transform.eulerAngles.y == 0f || obj12.transform.eulerAngles.y == 180f){b12 = true;}else{b12 = false;}
		}
		if(click_obj == obj13){
			if(obj13.transform.eulerAngles.y == 90f){b13 = true;}else{b13 = false;}
		}
		if(click_obj == obj14){
			if(obj14.transform.eulerAngles.y == 0f){b14 = true;}else{b14 = false;}
		}
		if(click_obj == obj15){
			if(obj15.transform.eulerAngles.y == 270f || obj15.transform.eulerAngles.y == 180f){b15 = true;}else{b15 = false;}
		}
		if(click_obj == obj16){
			if(obj16.transform.eulerAngles.y == 90f || obj16.transform.eulerAngles.y == 180f){b16 = true;}else{b16 = false;}
		}
		if(click_obj == obj17){
			if(obj17.transform.eulerAngles.y == 90f){b17 = true;}else{b17 = false;}
		}
		if(click_obj == obj18){
			if(obj18.transform.eulerAngles.y == 0f){b18 = true;}else{b18 = false;}
		}
		if(click_obj == obj19){
			if(obj19.transform.eulerAngles.y == 90f || obj19.transform.eulerAngles.y == 270f){b19 = true;}else{b19 = false;}
		}
		if(click_obj == obj20){
			if(obj20.transform.eulerAngles.y == 90f || obj20.transform.eulerAngles.y == 270f){b20 = true;}else{b20 = false;}
		}
		if(click_obj == obj21){
			if(obj21.transform.eulerAngles.y == 0f || obj21.transform.eulerAngles.y == 270f){b21 = true;}else{b21 = false;}
		}
		if(click_obj == obj22){
			if(obj22.transform.eulerAngles.y == 180f){b22 = true;}else{b22 = false;}
		}
		if(click_obj == obj23){
			if(obj23.transform.eulerAngles.y == 270f){b23 = true;}else{b23 = false;}
		}
		if(click_obj == obj24){
			if(obj24.transform.eulerAngles.y == 0f || obj24.transform.eulerAngles.y == 90f){b24 = true;}else{b24 = false;}
		}
		if(click_obj == obj25){
			if(obj25.transform.eulerAngles.y == 270f){b25 = true;}else{b25 = false;}
		}
		if(click_obj == obj26){
			if(obj26.transform.eulerAngles.y == 180f){b26 = true;}else{b26 = false;}
		}
		if(click_obj == obj27){
			if(obj27.transform.eulerAngles.y == 0f || obj27.transform.eulerAngles.y == 180f){b27 = true;}else{b27 = false;}
		}
		if(click_obj == obj28){
			if(obj28.transform.eulerAngles.y == 0f || obj28.transform.eulerAngles.y == 180f){b28 = true;}else{b28 = false;}
		}

		b = (b11 && b12) && (b13 && b14) && (b15 && b16) && (b17 && b18) && ( b19 && b20) && (b21 & b22) && (b23 & b24) && (b25 && b26) && (b28 && b29);

		/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		if(click_obj == obj29){
			if(obj29.transform.eulerAngles.y == 0f || obj29.transform.eulerAngles.y == 180f){b29 = true;}else{b29 = false;}
		}
		if(click_obj == obj30){
			if(obj30.transform.eulerAngles.y == 0f || obj30.transform.eulerAngles.y == 180f){b30 = true;}else{b30 = false;}
		}
		if(click_obj == obj31){
			if(obj31.transform.eulerAngles.y == 90f){b31 = true;}else{b31 = false;}
		}
		if(click_obj == obj32){
			if(obj32.transform.eulerAngles.y == 0f){b32 = true;}else{b32 = false;}
		}
		if(click_obj == obj33){
			if(obj33.transform.eulerAngles.y == 270f ){b33 = true;}else{b33 = false;}
		}
		if(click_obj == obj34){
			if(obj34.transform.eulerAngles.y == 90f){b34 = true;}else{b34 = false;}
		}
		if(click_obj == obj35){
			if(obj35.transform.eulerAngles.y == 0f || obj35.transform.eulerAngles.y == 180f){b35 = true;}else{b35 = false;}
		}
		if(click_obj == obj36){
			if(obj36.transform.eulerAngles.y == 0f || obj36.transform.eulerAngles.y == 180f){b36 = true;}else{b36 = false;}
		}
		if(click_obj == obj37){
			if(obj37.transform.eulerAngles.y == 270f){b37 = true;}else{b37 = false;}
		}
		if(click_obj == obj38){
			if(obj38.transform.eulerAngles.y == 180f){b38 = true;}else{b38 = false;}
		}
		if(click_obj == obj39){
			if(obj39.transform.eulerAngles.y == 0f || obj39.transform.eulerAngles.y == 180f){b39 = true;}else{b39 = false;}
		}
		if(click_obj == obj40){
			if(obj40.transform.eulerAngles.y == 0f || obj40.transform.eulerAngles.y == 180f){b40 = true;}else{b40 = false;}
		}

		c = (b29 && b30) && (b31 && b32) && (b33 && b34) && (b35 && b36) && (b37 && b38) && (b39 && b40);

		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		if(click_obj == obj58){
			if(obj58.transform.eulerAngles.y == 0f || obj58.transform.eulerAngles.y == 180f){b58 = true;}else{b58 = false;}
		}
		if(click_obj == obj57){
			if(obj57.transform.eulerAngles.y == 0f || obj57.transform.eulerAngles.y == 180f){b57 = true;}else{b57 = false;}
		}
		if(click_obj == obj56){
			if(obj56.transform.eulerAngles.y == 270f){b56 = true;}else{b56 = false;}
		}
		if(click_obj == obj55){
			if(obj55.transform.eulerAngles.y == 180f){b55 = true;}else{b55 = false;}
		}
		if(click_obj == obj54){
			if(obj54.transform.eulerAngles.y == 270f || obj54.transform.eulerAngles.y == 0f){b54 = true;}else{b54 = false;}
		}
		if(click_obj == obj53){
			if(obj53.transform.eulerAngles.y == 90f || obj53.transform.eulerAngles.y == 0f){b53 = true;}else{b53 = false;}
		}
		if(click_obj == obj52){
			if(obj52.transform.eulerAngles.y == 270f){b52 = true;}else{b52 = false;}
		}
		if(click_obj == obj51){
			if(obj51.transform.eulerAngles.y == 180f){b51 = true;}else{b51 = false;}
		}
		if(click_obj == obj50){
			if(obj50.transform.eulerAngles.y == 90f || obj50.transform.eulerAngles.y == 270f){b50 = true;}else{b50 = false;}
		}
		if(click_obj == obj49){
			if(obj49.transform.eulerAngles.y == 90f || obj49.transform.eulerAngles.y == 270f){b49 = true;}else{b49 = false;}
		}
		if(click_obj == obj46){
			if(obj46.transform.eulerAngles.y == 90f || obj46.transform.eulerAngles.y == 180f){b46 = true;}else{b46 = false;}
		}
		if(click_obj == obj47){
			if(obj47.transform.eulerAngles.y == 90f){b47 = true;}else{b47 = false;}
		}
		if(click_obj == obj48){
			if(obj48.transform.eulerAngles.y == 0f){b48 = true;}else{b48 = false;}
		}
		if(click_obj == obj45){
			if(obj45.transform.eulerAngles.y == 270f || obj45.transform.eulerAngles.y == 180f){b45 = true;}else{b45 = false;}
		}
		if(click_obj == obj44){
			if(obj44.transform.eulerAngles.y == 0f){b44 = true;}else{b44 = false;}
		}
		if(click_obj == obj43){
			if(obj43.transform.eulerAngles.y == 90f){b43 = true;}else{b43 = false;}
		}
		if(click_obj == obj42){
			if(obj42.transform.eulerAngles.y == 0f || obj42.transform.eulerAngles.y == 180f){b42 = true;}else{b42 = false;}
		}
		if(click_obj == obj41){
			if(obj41.transform.eulerAngles.y == 0f || obj41.transform.eulerAngles.y == 180f){b41 = true;}else{b41 = false;}
		}

		d = (b41 && b42) && (b43 && b44) && (b45 && b46) && (b47 && b48) && (b49 && b50) && (b51 && b52) && (b53 && b54) && (b55 && b56) && (b57 && b58);

			///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		if(click_obj == obj68){
			if(obj68.transform.eulerAngles.y == 0f || obj68.transform.eulerAngles.y == 180f){b68 = true;}else{b68 = false;}
		}
		if(click_obj == obj67){
			if(obj67.transform.eulerAngles.y == 0f || obj67.transform.eulerAngles.y == 180f){b67 = true;}else{b67 = false;}
		}
		if(click_obj == obj66){
			if(obj66.transform.eulerAngles.y == 270f){b66 = true;}else{b66 = false;}
		}
		if(click_obj == obj65){
			if(obj65.transform.eulerAngles.y == 180f){b65 = true;}else{b65 = false;}
		}
		if(click_obj == obj64){
			if(obj64.transform.eulerAngles.y == 90f || obj64.transform.eulerAngles.y == 270f){b64 = true;}else{b64 = false;}
		}
		if(click_obj == obj63){
			if(obj63.transform.eulerAngles.y == 90f || obj63.transform.eulerAngles.y == 270f){b63 = true;}else{b63 = false;}
		}
		if(click_obj == obj62){
			if(obj62.transform.eulerAngles.y == 0f){b62 = true;}else{b62 = false;}
		}
		if(click_obj == obj61){
			if(obj61.transform.eulerAngles.y == 90f){b61 = true;}else{b61 = false;}
		}
		if(click_obj == obj59){
			if(obj59.transform.eulerAngles.y == 0f || obj59.transform.eulerAngles.y == 180f){b59 = true;}else{b59 = false;}
		}
		if(click_obj == obj60){
			if(obj60.transform.eulerAngles.y == 0f || obj60.transform.eulerAngles.y == 180f){b60 = true;}else{b60 = false;}
		}
		e = (b60 && b61) && (b62 && b63) && (b64 && b65) && (b66 && b67) && (b68);	
	}

	public bool[] pass_bool1()
	{		bool[] bo = {a, b, c, d, e} ;
			return bo;
	}

}
