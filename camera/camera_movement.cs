using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour {

	public GameObject initial_pos;
	public GameObject level_start_pos;
	public GameObject level_end_pos;

	public ParticleSystem[] fire_works;
	int particle_length;

	public float init_speed;
	public float final_speed;

	public GameObject touchActive;

	bool isDone = false;
	bool level_start_bool = true;

	bool b1;
	

	#region Singleton
	public static camera_movement Instance;
	private void Awake() {
		Instance = this;
	}
	#endregion

	// Use this for initialization
	void Start () {
		transform.position = initial_pos.transform.position;
		level_start_bool = true;
		level_start_bool = true;
		touchActive.SetActive(true);
		particle_length = fire_works.Length;
		isDone = false;
		stop_particle_effect();
	}
	
	// Update is called once per frame
	void Update () {
		if(isDone){
			transform.position = Vector3.Lerp(transform.position, level_end_pos.transform.position, final_speed*Time.deltaTime);
			play_particle_effect();
			return;
		}

		if(level_start_bool){
		//transform.position = Vector3.Lerp(transform.position, level_start_pos.transform.position, init_speed*Time.deltaTime);
		StartCoroutine(stop_start_anim());
		}

	}

	public void level_done(bool b){
		isDone = b;
	}

	public bool pass_level_done_bool(){
		return isDone;
	}

	IEnumerator stop_start_anim(){
		yield return new WaitForSeconds(5.0f);
		transform.position = Vector3.Lerp(transform.position, level_start_pos.transform.position, init_speed*Time.deltaTime);
		level_start_bool = false;
		touchActive.SetActive(false);
		
	}


	public bool pass_start_anim_bool(){
		return level_start_bool;
	}

	void stop_particle_effect(){
		for(int i = 0;i<particle_length;i++){
		fire_works[i].Stop();
		}
	}

	void play_particle_effect(){
		for(int i = 0;i<particle_length;i++){
		fire_works[i].Play();
		}
	}

	public bool moveCam(){
		b1 = level_start_bool || isDone;
		return b1;
	}

}
