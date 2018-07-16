using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainAudio : MonoBehaviour {

	int x = 0;
	public AudioClip[] levelAudio;
	public AudioClip menuaudio;

	AudioSource a;

	string current;

	Scene current_S, next_S;


	// Use this for initialization
	void Start () {
		a = GetComponent<AudioSource>();
		playAudeo();
		current_S = SceneManager.GetActiveScene();
	}
	
	// Update is called once per frame
	void Update () {
		next_S = SceneManager.GetActiveScene();
		if(current_S != next_S)
		{
			x = Random.Range(0,2);
			a.clip = levelAudio[x];
			a.Play();
			current_S = next_S;
		}
	}

	void playAudeo()
	{
		current = SceneManager.GetActiveScene().name;
		if(current.Equals("MainMenu"))
		{
			a.clip = menuaudio;
			a.Play();
		}else{
			x = Random.Range(0,2);
			a.clip = levelAudio[x];
			a.Play();
		}
	}
}
