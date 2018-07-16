using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Play_audio : MonoBehaviour {

	change_rot cr;
	GameObject play;

	public AudioSource tap;
	public AudioClip tap_effect;


	// Use this for initialization
	void Start () {
		cr = change_rot.Instance;
		play = cr.pass_gameobject();

		tap.clip = tap_effect;
	}
	
	// Update is called once per frame
	void Update () {
		play = cr.pass_gameobject();
		if(play){tap.Play();}
	}

}
