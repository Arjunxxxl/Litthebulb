using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetStars : MonoBehaviour {

	GameManager manager;
	public int[] arr;

	int i;

	public TMP_Text[] txt;

	// Use this for initialization
	void Start () {
		manager = GameManager.Instance;
		arr = manager.PassStarData();
		if(arr.Length == txt.Length){
		setvalue();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void setvalue()
	{	
		for(i=0;i<txt.Length;i++){
			txt[i].text = ""+arr[i];
			if(arr[i] == -1) {txt[i].text = "-";}
		}
	}

}
