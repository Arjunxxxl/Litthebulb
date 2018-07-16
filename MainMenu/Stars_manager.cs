using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stars_manager : MonoBehaviour {

	GameManager manager;
	int[] arr;

	int l1=0,l2=0,l3=0;
	int for_level2, for_level3;

	public bool level2 = false, level3 = false;

	public Light l1_2,l2_3;

	Color red = new Color(1,0,0,1);
	Color green = new Color(0,1,0,1);

	public TMP_Text l1_txt,l2_txt,l3_txt,total;
	int t;

	public GameObject level2_status, level3_status;

	#region Singleton
	public static Stars_manager Instance;
	void Awake()
	{	
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		manager = GameManager.Instance;
		arr = manager.PassStarData();

		level1_stars(); level2_stars(); level3_stars();
		t =l1+l2+l3;
		for_level2 = 25;
		for_level3 = 45;

		if(level2){
			l1_2.color = green;
		}else{
			l1_2.color = red;
		}

		if(level3){
			l2_3.color = green;
		}else{
			l2_3.color = red;
		}

		l1_txt.text = l1+ "";	l2_txt.text = l2+ "";	l3_txt.text = l3+ "";
		total.text = t+"";

	}
	
	// Update is called once per frame
	void Update () {
		if(l1>24){level2 = true;}
		if((l1+l2)>44){level3 = true;}

		if(level2){
			l1_2.color = Color.Lerp(red,green,2*Time.deltaTime);
		}else{
			l1_2.color = red;
		}

		if(level3){
			l2_3.color = Color.Lerp(red,green,2*Time.deltaTime);
		}else{
			l2_3.color = red;
		}

		if(level2){level2_status.SetActive(false);}
		if(level3){level3_status.SetActive(false);}
		
	}

	void level1_stars()
	{
		for(int i=0;i<10;i++)
		{
			l1+=arr[i];
		}
	}

	void level2_stars()
	{
		for(int i=10;i<18;i++)
		{
			l2+=arr[i];
		}
	}

	void level3_stars()
	{
		for(int i=18;i<28;i++)
		{
			l3+=arr[i];
		}
	}

	public bool[] PassData_bulb(){
			bool[] b = {level2,level3};
			return b;
	}

}
