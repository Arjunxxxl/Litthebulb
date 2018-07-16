using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class electrician_walk : MonoBehaviour {

	private Animator anim;
	private NavMeshAgent mAgent;
	public GameObject des1,des2;
	GameObject des;

	bool walk = false;
	bool work = false;
	bool win = false;

	float t = 10.0f;
	float t2 = 0.0f;

	//circuit1 c1;
	//bool islit;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		mAgent = GetComponent<NavMeshAgent>();
		//c1 = circuit1.Instance;
		//islit = c1.pass_bool();
		des = des1;
	}
	
	// Update is called once per frame
	void Update () {
		move();
	}

	void move(){
			//islit = c1.pass_bool();
			//win = islit;
			/*if(win){
				anim.SetBool("level_complete",win);
				anim.SetBool("isWalk",false);
				anim.SetBool("useMachine",false);
				mAgent.destination = transform.position;
				return;
			}*/
			//else{
				mAgent.destination = des.transform.position;
					walk = false;
					work = false;
				if(mAgent.remainingDistance >= mAgent.stoppingDistance){
					walk = true;
					
				}else{
					
					work = true;
					t2 += Time.deltaTime;
				if(t2>t){
					if(des == des1){des = des2;}	else{des = des1;} t2 = 0.0f;
				}
					
				}
				
				//anim.SetBool("level_complete",false);
				anim.SetBool("isWalk",walk);
				anim.SetBool("useMachine",work);

				
			//}
	}
	
	
		
	

}
