using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour {

	float dragSpeed = 40.0f;
    private Vector3 dragOrigin;
   
    public bool cameraDragging = true;
   
    public float outerLeft ;
    public float outerRight ;

	public float outerLeft_z ;
    public float outerRight_z;

 
	float x,y,z;

	Vector3 pos,move,mousePosition,m;
	float left,right;

    float wait = 4.0f;
    
    bool moveCam;
  
   void Start()
   {
	   //y = transform.position.y;
       y = 45.0f;  //------- IMPORATANT ----- un commnent this and comment above line ------
      wait = 4.0f;
   }

    void Update()
    {   
        wait -= Time.deltaTime;
        if(wait>0){return;}
       
		x =transform.position.x;
		z = transform.position.z;
           
        mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
       
        left = Screen.width * 0.2f;
        right = Screen.width - (Screen.width * 0.2f);
       
        if(mousePosition.x < left)
        {
            cameraDragging = true;
        }
        else if(mousePosition.x > right)
        {
            cameraDragging = true;
        }
       
        if (cameraDragging) {
           
            if (Input.GetMouseButtonDown(0))
            {
                dragOrigin = Input.mousePosition;
                return;
            }
           
            if (!Input.GetMouseButton(0)) return;
           
            pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
            move = new Vector3(-pos.y * dragSpeed*Time.deltaTime, 0, pos.x * dragSpeed*Time.deltaTime);
           
             transform.Translate(move, Space.World);
			
			 if(transform.position.x > outerRight){
				 m = new Vector3 (outerRight , y ,z);
				 transform.position = m;
			 } else  if(transform.position.x < outerLeft){
				 m = new Vector3 (outerLeft , y ,z);
				 transform.position = m;
			 }

			 if(transform.position.z > outerRight_z){
				 m = new Vector3 (x , y ,outerRight_z);
				 transform.position = m;
			 } else  if(transform.position.z < outerLeft_z){
				 m = new Vector3 (x , y ,outerLeft_z);
				 transform.position = m;
			 }

        }
    }
   
}
