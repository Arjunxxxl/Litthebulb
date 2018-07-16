using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electrician_idle : MonoBehaviour {

	
	private Animator anim;
	

	//circuit1 c1;
	bool islit,win;
	bool work;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		
		//c1 = circuit1.Instance;
		//islit = c1.pass_bool();
		
	}
	
	// Update is called once per frame
	void Update () {
		move();
	}

	void move(){
			//islit = c1.pass_bool();
			//win = islit;
			//work = !win;
			anim.SetBool("level_complete",false);
			anim.SetBool("work",true);
	}
	
}
