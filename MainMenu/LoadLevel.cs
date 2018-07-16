using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour {

	public Slider bar;
	public GameObject loading_screen;

	float progress ;
	AsyncOperation op;
	float loading_precentage;

	private void Start() {
		loading_screen.SetActive(false);
	}

	public void level1_1()
	{
		StartCoroutine(load_level("circuit1"));
	}
	public void level1_2()
	{
		StartCoroutine(load_level("circuit1_2"));
	}
	public void level1_3()
	{
		StartCoroutine(load_level("circuit1_3"));
	}
	public void level1_4()
	{
		StartCoroutine(load_level("circuit1_4"));
	}
	public void level1_5()
	{
		StartCoroutine(load_level("circuit1_5"));
	}
	public void level1_6()
	{
		StartCoroutine(load_level("circuit1_6"));
	}
	public void level1_7()
	{
		StartCoroutine(load_level("circuit1_7"));
	}
	public void level1_8()
	{
		StartCoroutine(load_level("circuit1_8"));
	}
	public void level1_9()
	{
		StartCoroutine(load_level("circuit1_9"));
	}
	public void level1_10()
	{
		StartCoroutine(load_level("circuit1_10"));
	}
	/////////////////////////////////////////////////////////////////////////////
	public void level2_1()
	{
		StartCoroutine(load_level("circuit2_1"));
	}
	public void level2_2()
	{
		StartCoroutine(load_level("circuit2_2"));
	}
	public void level2_3()
	{
		StartCoroutine(load_level("circuit2_3"));
	}
	public void level2_4()
	{
		StartCoroutine(load_level("circuit2_4"));
	}
	public void level2_5()
	{
		StartCoroutine(load_level("circuit2_5"));
	}
	public void level2_6()
	{
		StartCoroutine(load_level("circuit2_6"));
	}
	public void level2_7()
	{
		StartCoroutine(load_level("circuit2_7"));
	}
	public void level2_8()
	{
		StartCoroutine(load_level("circuit2_8"));
	}
	/////////////////////////////////////////////////////////////////////////////
	public void level3_1()
	{
		StartCoroutine(load_level("circuit3"));
	}
	public void level3_2()
	{
		StartCoroutine(load_level("circuit3_2"));
	}
	public void level3_3()
	{
		StartCoroutine(load_level("circuit3_3"));
	}
	public void level3_4()
	{
		StartCoroutine(load_level("circuit3_4"));
	}
	public void level3_5()
	{
		StartCoroutine(load_level("circuit3_5"));
	}
	public void level3_6()
	{
		StartCoroutine(load_level("circuit3_6"));
	}
	public void level3_7()
	{
		StartCoroutine(load_level("circuit3_7"));
	}
	public void level3_8()
	{
		StartCoroutine(load_level("circuit3_8"));
	}
	public void level3_9()
	{
		StartCoroutine(load_level("circuit3_9"));
	}
	public void level3_10()
	{
		StartCoroutine(load_level("circuit3_10"));
	}
	/////////////////////////////////////////////////////////////////////////////

	IEnumerator load_level(string name){
			
			op = SceneManager.LoadSceneAsync(name);
			loading_screen.SetActive(true);
			while(!op.isDone){
				progress = Mathf.Clamp01(op.progress/0.9f);
				loading_precentage = progress*100;
				bar.value = progress;
				yield return null;
			}
	}
	
}
