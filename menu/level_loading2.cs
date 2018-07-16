using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level_loading2 : MonoBehaviour {

	public Slider bar;
	public GameObject loading_screen;

	camera_movement cm;
	bool complete = false;

	Scene current_scene;
	string current_scene_name;

	/*public Image i1,i2,i3,i4,i5;
	public Sprite b1;*/

	float progress ;
	AsyncOperation op;
	float loading_precentage;

	public GameObject level_end_menu;

	// Use this for initialization
	void Start () {
		loading_screen.SetActive(false);
		cm = camera_movement.Instance;
		complete = false;
		level_end_menu.SetActive(false);
		Time.timeScale = 1.0f;
		
		current_scene = SceneManager.GetActiveScene();
		current_scene_name = current_scene.name;
		
	}
	
	// Update is called once per frame
	void Update () {
		complete = cm.pass_level_done_bool();
		if(complete){
			StartCoroutine(wait_before_next());
		}
	}

	IEnumerator wait_before_next(){
		yield return new WaitForSeconds(2.0f);
		//StartCoroutine(load_level("circuit1_2"));
		level_end_menu.SetActive(true);
		Time.timeScale = 0.0f;
		}

	public void Next_level()	
	{
		switch(current_scene_name){
			case "circuit2_1" : StartCoroutine(load_level("circuit2_2"));		break;
			case "circuit2_2" : StartCoroutine(load_level("circuit2_3"));		break;
			case "circuit2_3" : StartCoroutine(load_level("circuit2_4"));		break;
			case "circuit2_4" : StartCoroutine(load_level("circuit2_5"));		break;
			case "circuit2_5" : StartCoroutine(load_level("circuit2_6"));		break;
			case "circuit2_6" : StartCoroutine(load_level("circuit2_7"));		break;
			case "circuit2_7" : StartCoroutine(load_level("circuit2_8"));		break;
			case "circuit2_8" : StartCoroutine(load_level("circuit2_9"));		break;
			case "circuit2_9" : StartCoroutine(load_level("circuit2_10"));		break;
			case "circuit2_10" : StartCoroutine(load_level("circuit2_1"));		break;
		}
	}

	public void Load_current_level(){
		 StartCoroutine(load_level(current_scene_name));
	}

	public void Menu()
	{
		StartCoroutine(load_level("MainMenu"));
	}

	IEnumerator load_level(string name){
			
			op = SceneManager.LoadSceneAsync(name);
			loading_screen.SetActive(true);
			while(!op.isDone){
				progress = Mathf.Clamp01(op.progress/0.9f);
				loading_precentage = progress*100;
				/*if(loading_precentage >=5.0f){i1.sprite = b1;}
				if(loading_precentage >=25.0f){i2.sprite = b1;}
				if(loading_precentage >=50.0f){i3.sprite = b1;}
				if(loading_precentage >=75.0f){i4.sprite = b1;}
				if(loading_precentage >=98.0f){i5.sprite = b1;}*/
				bar.value = progress;
				yield return null;
			}
	}
}
