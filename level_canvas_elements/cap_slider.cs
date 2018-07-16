using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cap_slider : MonoBehaviour {

	Slider s;


	// Use this for initialization
	void Start () {
		s = gameObject.GetComponent<Slider>();
		s.value = 5;
		gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		s.value-=1*Time.deltaTime;

		if(s.value == 0 || s.value < 0){
			{StartCoroutine(setFasle(gameObject));}
		}
	}

	private void OnEnable() {
		if(!s){return;}
		s.value = 5;
	}

	IEnumerator setFasle(GameObject o)
	{
		yield return new WaitForSeconds(1f);
		o.SetActive(false);
	}

}