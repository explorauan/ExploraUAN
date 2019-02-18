using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonZoom : MonoBehaviour {

	private bool toggle = true;        // Is the camera zoomed in
 	private float time;
 
	int zoom = 20;
	int normal = 60;
	float smooth = 5;
	 
	void Awake() {
	 
	}
	 
	void Start () {
	 
	}
	 
	void Update () {
	// Your touch input here and call zoomCamera function
	 
	}
	 
	void zoomCamera(){
	time = smooth;
	 
	    if(toggle){
	        while (time > 0.0f){
	            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView,zoom,Time.deltaTime*smooth);
	            time -= Time.deltaTime;
	        }
	            toggle=false;	 
	    }
	    else{
        	while (time > 0.0f){
            	Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView,normal,Time.deltaTime*smooth);
            	time -= Time.deltaTime;
	        }
            toggle=true;
	    }  
	}      
}
