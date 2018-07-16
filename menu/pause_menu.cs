using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class pause_menu : MonoBehaviour {

	public GameObject menu_pause;
	public GameObject pause_button;

	public AudioMixer music;
	public AudioMixer sfx;

	public Image m,s;

	public Sprite music_on,music_off;
	public Sprite sfx_on,sfx_off;

	float music_val = 0f,sfx_val = 0f;
	bool music_b,sfx_v;


	// Use this for initialization
	void Start () {
		menu_pause.SetActive(false);
		pause_button.SetActive(true);	
		Time.timeScale = 1.0f;
		
	}
	

	public void pauseGame(){
		menu_pause.SetActive(true);
		pause_button.SetActive(false);
		Time.timeScale = 0.0f;
	}

	public void resumeGame(){
		menu_pause.SetActive(false);
		pause_button.SetActive(true);
		Time.timeScale = 1.0f;
	}

	public void Set_music()
	{	
		music_b = music.GetFloat("music_vol", out music_val);
		
		if(music_val == -80f)
		{
			music.SetFloat("music_vol", 0);
			m.sprite = music_on;
		}else if(music_val == 0f){
			music.SetFloat("music_vol", -80);
			m.sprite = music_off;
		}

	PlayerPrefs.SetFloat("music", music_val);
		PlayerPrefs.Save();
	}

	public void Set_sfx()
	{	
		sfx_v = sfx.GetFloat("sfx_vol", out sfx_val);
		if(sfx_val == -80f)
		{
			sfx.SetFloat("sfx_vol", 0);
			s.sprite = sfx_on;
			 
		}else if(sfx_val == 0f){
			sfx.SetFloat("sfx_vol", -80);
			s.sprite = sfx_off;
		}

		PlayerPrefs.SetFloat("sfx", sfx_val);
		PlayerPrefs.Save();

	}


}
