using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class level_timer : MonoBehaviour {

	public float t;

	int stars = 3;

	public float a,b,c;

	public Slider s;
	public TMP_Text txt;
	bool wait = true;

	GameManager manager;

	public TMP_Text star_text;

	#region Singleton
	public static level_timer Instance;
	void Awake()
	{
		Instance = this;	
	}
	#endregion

	

	// Use this for initialization
	void Start () {
		a = t - t/3;
		b = t - 2*t/3;
		c = t - 5*t/6;
		s.maxValue = t;
		s.minValue = 0f;
		s.value = t;
		stars = 3;
		star_text.text = "" + stars;
		txt.text = "Time : " + (int)t;

		manager = GameManager.Instance;
		}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(start_timer());
		if(wait){return;}
		if(t == 0 || t < 0) {return;}
		t -= 1*Time.deltaTime;
		s.value = t;
		txt.text = "Time : " + (int)t;
		if(t>=a){stars = 3;}
		else if(t<a && t>=b){stars = 2;}
		else if(t<b && t>=c){stars = 1;}
		else {stars = 0;}

		star_text.text = "" + stars;

		manager.SetStarsData(stars);
	}

	IEnumerator start_timer()
	{
		yield return new WaitForSeconds(8.0f);
		wait = false;
	}

	public int passStars()
	{
		return stars;
	}

}
