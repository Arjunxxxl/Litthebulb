using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio_canvas : MonoBehaviour {

	
	public AudioClip gui_effect;
	public AudioSource gui;

	// Use this for initialization
	void Start () {
		gui.clip = gui_effect;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
	public void Play_ongui()
	{
		gui.Play();
	}
}
