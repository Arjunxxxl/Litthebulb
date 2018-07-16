using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class MenuAnimController : MonoBehaviour {

	public List<PlayableDirector> playable;

	public List<PlayableDirector> Box;
	public GameObject playMenu; 
	public GameObject levelMenu;
	public GameObject l1,l2,l3;

	Stars_manager sm;

	bool[] l;

	public GameObject Settings_menu, vol, graphics,about_us_menu,social;
	

	void Start()
	{
		levelMenu.SetActive(false);
		l1.SetActive(false);	l2.SetActive(false);	l3.SetActive(false);
		playMenu.SetActive(true);
		Settings_menu.SetActive(false);	vol.SetActive(false);	graphics.SetActive(false);
		about_us_menu.SetActive(false);	social.SetActive(false);
		sm = Stars_manager.Instance;
		l = sm.PassData_bulb();
	}

	private void Update()
	{
		l = sm.PassData_bulb();
	}

	public void Play_button()
	{	
		playable[0].Play();
		Stop_playable(1);
		Stop_playable(2);
		playMenu.SetActive(false);
		StartCoroutine(setActiveObj(levelMenu));
		
	}

	public void Level_back()
	{	
		playable[1].Play();
		Stop_playable(0);
		levelMenu.SetActive(false);
		StartCoroutine(setActiveObj(playMenu));
		
	}

	public void Level1_Select(){
		playable[4].Play();
		levelMenu.SetActive(false);
		StartCoroutine(setActiveObj(l1));
		Box[0].Play();
		Box[1].Stop();
		Stop_playable(5);
	}

	public void Level1_Select_back(){
		playable[5].Play();
		l1.SetActive(false);
		StartCoroutine(setActiveObj(levelMenu));
		Box[1].Play();
		Box[0].Stop();
		Stop_playable(4);
	}

	public void Level2_Select(){
		if(!l[0]){return;}
		playable[6].Play();
		levelMenu.SetActive(false);
		StartCoroutine(setActiveObj(l2));
		Box[2].Play();
		Box[3].Stop();
		Stop_playable(7);
	}

	public void Level2_Select_back(){
		playable[7].Play();
		l2.SetActive(false);
		StartCoroutine(setActiveObj(levelMenu));
		Box[3].Play();
		Box[2].Stop();
		Stop_playable(6);
	}

	public void Level3_Select(){
		if(!l[1]){return;}
		playable[8].Play();
		levelMenu.SetActive(false);
		StartCoroutine(setActiveObj(l3));
		Box[4].Play();
		Stop_playable(9);
		Box[5].Stop();
	}

	public void Level3_Select_back(){
		playable[9].Play();
		l3.SetActive(false);
		StartCoroutine(setActiveObj(levelMenu));
		Box[5].Play();
		Stop_playable(8);
		Box[4].Stop();
	}

	public void Settings()
	{
		playable[2].Play();
		playMenu.SetActive(false);
		StartCoroutine(setActiveObj(Settings_menu));
		Stop_playable(3);
	}

	public void Settings_back()
	{
		playable[3].Play();
		Settings_menu.SetActive(false);
		StartCoroutine(setActiveObj(playMenu));
		Stop_playable(2);
	}

	public void Quality()
	{
		playable[12].Play();
		Settings_menu.SetActive(false);
		StartCoroutine(setActiveObj(graphics));
		Stop_playable(13);
	}

	public void Quality_Rev()
	{
		playable[13].Play();
		graphics.SetActive(false);
		StartCoroutine(setActiveObj(Settings_menu));
		Stop_playable(12);
	}

	public void Vol_menu()
	{
		playable[10].Play();
		Settings_menu.SetActive(false);
		StartCoroutine(setActiveObj(vol));
		Stop_playable(11);
	}

	public void Vol_menu_Rev()
	{
		playable[11].Play();
		vol.SetActive(false);
		StartCoroutine(setActiveObj(Settings_menu));
		Stop_playable(10);
	}

	IEnumerator setActiveObj(GameObject o)
	{	
		Debug.Log("active");
		yield return new WaitForSeconds(1f);
		o.SetActive(true);
	}

	public void About_us()
	{	
		playable[14].Play();
		Stop_playable(15);
		playMenu.SetActive(false);
		StartCoroutine(setActiveObj(about_us_menu));
		StartCoroutine(setActiveObj(social));
	}

	public void About_us_back()
	{	
		playable[15].Play();
		Stop_playable(14);
		about_us_menu.SetActive(false);
		social.SetActive(false);
		StartCoroutine(setActiveObj(playMenu));
		
	}

	void Stop_playable(int i)
	{
		playable[i].Stop();
	}

}
