using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class instruct : MonoBehaviour {

	public int level1_instruct =0,level2_instruct = 0,level3_instruct = 0;

	string current;

	public GameObject instructions;
	public GameObject[] all_instruct;

	public List<PlayableDirector> d;

	private void Start()
	{	
		check_already();
		//PlayerPrefs.DeleteKey("level1_instruct");
		setActive1();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void check_already()
	{
		current = SceneManager.GetActiveScene().name;
		if(current.Equals("circuit1")){
		level1_instruct = PlayerPrefs.GetInt("level1_instruct");
		if( level1_instruct == 0 )
		{	instructions.SetActive(true);
			Time.timeScale = 0.0f;
   			PlayerPrefs.SetInt( "level1_instruct", 1 );
		}else{instructions.SetActive(false);}
		}

		if(current.Equals("circuit2_1")){
		level2_instruct = PlayerPrefs.GetInt("level2_instruct");
		if( level2_instruct == 0 )
		{
   			PlayerPrefs.SetInt( "level2_instruct", 1 );
			instructions.SetActive(true);
			Time.timeScale = 0f;
		}else{instructions.SetActive(false);}
		}

		if(current.Equals("circuit3_1")){
		level3_instruct = PlayerPrefs.GetInt("level3_instruct");
		if( level3_instruct == 0 )
		{
   			PlayerPrefs.SetInt( "level3_instruct", 1 );
			instructions.SetActive(true); 
			Time.timeScale = 0f;  
		}else{instructions.SetActive(false);}
		}
	}

	void setActive1()
	{
		if(current.Equals("circuit1"))
		{
			if(instructions.activeSelf)
			{
				all_instruct[0].SetActive(true);
			}
		}

		if(current.Equals("circuit2_1"))
		{
			if(instructions.activeSelf)
			{
				all_instruct[0].SetActive(true);
			}
		}

		if(current.Equals("circuit3_1"))
		{
			if(instructions.activeSelf)
			{
				all_instruct[0].SetActive(true);
			}
		}
	}

	public void next1()
	{
		all_instruct[0].SetActive(false);
		all_instruct[1].SetActive(true);
		d[0].Stop();
	}

	public void back1()
	{
		all_instruct[1].SetActive(false);
		all_instruct[0].SetActive(true);
		d[1].Stop();
		d[0].Play();
	}

	public void next2()
	{
		all_instruct[1].SetActive(false);
		all_instruct[2].SetActive(true);
		d[1].Stop();
		d[2].Play();
	}

	public void back2()
	{
		all_instruct[2].SetActive(false);
		all_instruct[1].SetActive(true);
		d[2].Stop();
		d[1].Play();
	}

	public void done()
	{
		instructions.SetActive(false);
		Time.timeScale = 1f;
	}

}
