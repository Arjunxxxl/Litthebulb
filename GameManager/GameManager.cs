using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public int a1_1,a1_2,a1_3,a1_4,a1_5,a1_6,a1_7,a1_8,a1_9,a1_10,
		a2_1,a2_2,a2_3,a2_4,a2_5,a2_6,a2_7,a2_8,
		a3_1,a3_2,a3_3,a3_4,a3_5,a3_6,a3_7,a3_8,a3_9,a3_10;

	public string A_data1_1 = "A_data1_1", A_data1_2 = "A_data1_2",A_data1_3 = "A_data1_3",A_data1_4 = "A_data1_4",A_data1_5 = "A_data1_5",A_data1_6 = "A_data1_6",
					A_data1_7 = "A_data1_7",A_data1_8 = "A_data1_8",A_data1_9 = "A_data1_9",A_data1_10 = "A_data1_10",
					A_data2_1 = "A_data2_1",A_data2_2 = "A_data2_2",A_data2_3 = "A_data2_3",A_data2_4 = "A_data2_4",A_data2_5 = "A_data2_5",A_data2_6 = "A_data2_6"
					,A_data2_7 = "A_data2_7",A_data2_8 = "A_data2_8",
					A_data3_1 = "A_data3_1",A_data3_2 = "A_data3_2",A_data3_3 = "A_data3_3",A_data3_4 = "A_data3_4",
					A_data3_5 = "A_data3_5",A_data3_6 = "A_data3_6",A_data3_7 = "A_data3_7",A_data3_8 = "A_data3_8",
					A_data3_9 = "A_data3_9",A_data3_10 = "A_data3_10";	

	string currentscene;

	camera_movement cm;	

	public int hasPlayed;


	#region Singleton
	public static GameManager Instance;
	void Awake()
	{	
		if(!Instance){
		Instance = this;
		DontDestroyOnLoad(this.gameObject);
		}else{Destroy(gameObject);}
	}
	#endregion

	// Use this for initialization
	void Start () {

		currentscene = SceneManager.GetActiveScene().name;
		if(!currentscene.Equals("MainMenu")){
		cm = camera_movement.Instance;
		}
		hasPlayed = PlayerPrefs.GetInt("HasPlayed",2);
		if( hasPlayed == 1 )
		{
   			PlayerPrefs.SetInt( "HasPlayed", 2 );
			SaveStarData_Default();
		}
		else
		{
			
		}
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnApplicationQuit()
	{
		PlayerPrefs.Save();
		//PlayerPrefs.DeleteAll();
	}

	public void SetStarsData(int data)
	{		
		currentscene = SceneManager.GetActiveScene().name;
		if(!currentscene.Equals("MainMenu")){
			//if(cm.pass_level_done_bool())
			{
				getData1(data);
				PlayerPrefs.Save();
			}
		}	

	}

	void getData1(int d)
	{
		if(currentscene.Equals("circuit1")){a1_1 = d;}		else if(currentscene.Equals("circuit1_6")){a1_6 = d;}
		else if(currentscene.Equals("circuit1_2")){a1_2 = d;}	else if(currentscene.Equals("circuit1_7")){a1_7 = d;}
		else if(currentscene.Equals("circuit1_3")){a1_3 = d;}	else if(currentscene.Equals("circuit1_8")){a1_8 = d;}
		else if(currentscene.Equals("circuit1_4")){a1_4 = d;}	else if(currentscene.Equals("circuit1_9")){a1_9 = d;}
		else if(currentscene.Equals("circuit1_5")){a1_5 = d;}	else if(currentscene.Equals("circuit1_10")){a1_10 = d;}
		
		else if(currentscene.Equals("circuit2_1")){a2_1 = d;}		else if(currentscene.Equals("circuit2_6")){a2_6 = d;}
		else if(currentscene.Equals("circuit2_2")){a2_2 = d;}	else if(currentscene.Equals("circuit2_7")){a2_7 = d;}
		else if(currentscene.Equals("circuit2_3")){a2_3 = d;}	else if(currentscene.Equals("circuit2_8")){a2_8 = d;}
		else if(currentscene.Equals("circuit2_4")){a2_4 = d;}	
		else if(currentscene.Equals("circuit2_5")){a2_5 = d;}	
		
		else if(currentscene.Equals("circuit3_1")){a3_1 = d;}		else if(currentscene.Equals("circuit3_6")){a3_6 = d;}
		else if(currentscene.Equals("circuit3_2")){a3_2 = d;}	else if(currentscene.Equals("circuit3_7")){a3_7 = d;}
		else if(currentscene.Equals("circuit3_3")){a3_3 = d;}	else if(currentscene.Equals("circuit3_8")){a3_8 = d;}
		else if(currentscene.Equals("circuit3_4")){a3_4 = d;}	else if(currentscene.Equals("circuit3_9")){a3_9 = d;}
		else if(currentscene.Equals("circuit3_5")){a3_5 = d;}	else if(currentscene.Equals("circuit3_10")){a3_10 = d;}
		
		SaveStarData();
		PlayerPrefs.Save();
	}

	void SaveStarData()
	{
		PlayerPrefs.SetInt(A_data1_1, a1_1);	PlayerPrefs.SetInt(A_data1_2, a1_2);
		PlayerPrefs.SetInt(A_data1_3, a1_3);	PlayerPrefs.SetInt(A_data1_4, a1_4);
		PlayerPrefs.SetInt(A_data1_5, a1_5);	PlayerPrefs.SetInt(A_data1_6, a1_6);
		PlayerPrefs.SetInt(A_data1_7, a1_7);	PlayerPrefs.SetInt(A_data1_8, a1_8);
		PlayerPrefs.SetInt(A_data1_9, a1_9);	PlayerPrefs.SetInt(A_data1_10, a1_10);

		PlayerPrefs.SetInt(A_data2_1, a2_1);	PlayerPrefs.SetInt(A_data2_2, a2_2);
		PlayerPrefs.SetInt(A_data2_3, a2_3);	PlayerPrefs.SetInt(A_data2_4, a2_4);
		PlayerPrefs.SetInt(A_data2_5, a2_5);	PlayerPrefs.SetInt(A_data2_5, a2_5);
		PlayerPrefs.SetInt(A_data2_7, a2_7);	PlayerPrefs.SetInt(A_data2_8, a2_8);

		PlayerPrefs.SetInt(A_data3_1, a3_1);	PlayerPrefs.SetInt(A_data3_2, a3_2);
		PlayerPrefs.SetInt(A_data3_3, a3_3);	PlayerPrefs.SetInt(A_data3_4, a3_4);
		PlayerPrefs.SetInt(A_data3_5, a3_5);	PlayerPrefs.SetInt(A_data3_6, a3_6);
		PlayerPrefs.SetInt(A_data3_7, a3_7);	PlayerPrefs.SetInt(A_data3_8, a3_8);
		PlayerPrefs.SetInt(A_data3_9, a3_9);	PlayerPrefs.SetInt(A_data3_10, a3_10);
		PlayerPrefs.Save();
	}

	void SaveStarData_Default()
	{
		PlayerPrefs.SetInt(A_data1_1, 0);	PlayerPrefs.SetInt(A_data1_2, 0);
		PlayerPrefs.SetInt(A_data1_3, 0);	PlayerPrefs.SetInt(A_data1_4, 0);
		PlayerPrefs.SetInt(A_data1_5, 0);	PlayerPrefs.SetInt(A_data1_6, 0);
		PlayerPrefs.SetInt(A_data1_7, 0);	PlayerPrefs.SetInt(A_data1_8, 0);
		PlayerPrefs.SetInt(A_data1_9, 0);	PlayerPrefs.SetInt(A_data1_10, 0);

		PlayerPrefs.SetInt(A_data2_1, 0);	PlayerPrefs.SetInt(A_data2_2, 0);
		PlayerPrefs.SetInt(A_data2_3, 0);	PlayerPrefs.SetInt(A_data2_4, 0);
		PlayerPrefs.SetInt(A_data2_5, 0);	PlayerPrefs.SetInt(A_data2_5, 0);
		PlayerPrefs.SetInt(A_data2_7, 0);	PlayerPrefs.SetInt(A_data2_8, 0);

		PlayerPrefs.SetInt(A_data3_1, 0);	PlayerPrefs.SetInt(A_data3_2, 0);
		PlayerPrefs.SetInt(A_data3_3, 0);	PlayerPrefs.SetInt(A_data3_4, 0);
		PlayerPrefs.SetInt(A_data3_5, 0);	PlayerPrefs.SetInt(A_data3_6, 0);
		PlayerPrefs.SetInt(A_data3_7, 0);	PlayerPrefs.SetInt(A_data3_8, 0);
		PlayerPrefs.SetInt(A_data3_9, 0);	PlayerPrefs.SetInt(A_data3_10, 0);
		PlayerPrefs.Save();
	}

	void GetPref_data()
	{
		a1_1 = PlayerPrefs.GetInt(A_data1_1, 0);	a1_2 = PlayerPrefs.GetInt(A_data1_2, 0);
		a1_3 = PlayerPrefs.GetInt(A_data1_3, 0);	a1_4 = PlayerPrefs.GetInt(A_data1_4, 0);
		a1_5 = PlayerPrefs.GetInt(A_data1_5, 0);	a1_6 = PlayerPrefs.GetInt(A_data1_5, 0);
		a1_7 = PlayerPrefs.GetInt(A_data1_7, 0);	a1_8 = PlayerPrefs.GetInt(A_data1_8, 0);
		a1_9 = PlayerPrefs.GetInt(A_data1_9, 0);	a1_10 = PlayerPrefs.GetInt(A_data1_10, 0);

		a2_1 = PlayerPrefs.GetInt(A_data2_1, 0);	a2_2 = PlayerPrefs.GetInt(A_data2_2, 0);
		a2_3 = PlayerPrefs.GetInt(A_data2_3, 0);	a2_4 = PlayerPrefs.GetInt(A_data2_4, 0);
		a2_5 = PlayerPrefs.GetInt(A_data2_5, 0);	a2_6 = PlayerPrefs.GetInt(A_data2_5, 0);
		a2_7 = PlayerPrefs.GetInt(A_data2_7, 0);	a2_8 = PlayerPrefs.GetInt(A_data2_8, 0);

		a3_1 = PlayerPrefs.GetInt(A_data3_1, 0);	a3_2 = PlayerPrefs.GetInt(A_data3_2, 0);
		a3_3 = PlayerPrefs.GetInt(A_data3_3, 0);	a3_4 = PlayerPrefs.GetInt(A_data3_4, 0);
		a3_5 = PlayerPrefs.GetInt(A_data3_5, 0);	a3_6 = PlayerPrefs.GetInt(A_data3_5, 0);
		a3_7 = PlayerPrefs.GetInt(A_data3_7, 0);	a3_8 = PlayerPrefs.GetInt(A_data3_8, 0);
		a3_9 = PlayerPrefs.GetInt(A_data3_9, 0);	a3_10 = PlayerPrefs.GetInt(A_data3_10, 0);
		PlayerPrefs.Save();
	}

	public int[] PassStarData()
	{	
		GetPref_data();
		PlayerPrefs.Save();
		int[] arr= {a1_1,a1_2,a1_3,a1_4,a1_5,a1_6,a1_7,a1_8,a1_9,a1_10,
					a2_1,a2_2,a2_3,a2_4,a2_5,a2_6,a2_7,a2_8,
					a3_1,a3_2,a3_3,a3_4,a3_5,a3_6,a3_7,a3_8,a3_9,a3_10};
		return arr; 
	}

}
