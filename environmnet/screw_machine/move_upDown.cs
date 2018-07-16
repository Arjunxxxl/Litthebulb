using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_upDown : MonoBehaviour {

	Vector3 a,b;
	
    Vector3 des;

    float WAIT_TIme = 1.5f;
    float speed = 2.0f;

    public bool a_b= false;

    float deltaT;


	// Use this for initialization
	void Start () {
		a = new Vector3(transform.position.x,4.3f,transform.position.z);
		b = new Vector3(transform.position.x, 5.5f,transform.position.z);
        
        if(!a_b){
		des = b;
        transform.position = b;
            }else{
            des = a;
             transform.position = a;
            }

        deltaT = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
			 //transform.position = Vector3.Lerp(a, b, Mathf.PingPong(Time.time, 1));
			StartCoroutine(up_down(des));
	}

	IEnumerator up_down(Vector3 pos){
        yield return new WaitForSeconds(WAIT_TIme);
        if(pos == a){
            transform.position = Vector3.Lerp(transform.position, b, speed*deltaT);
            des = b;
        }else if(pos == b){
            transform.position = Vector3.Lerp(transform.position, a, speed*deltaT);
            des = a;
        }
    }
}
