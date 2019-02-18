using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour {

	public int zoom = 20;
	public int normal = 60;
	public float smooth = 3.0f;

	private bool isZoomed = false;

	void update(){
		if(Input.GetMouseButtonDown(1)){
			isZoomed = !isZoomed;
		}

		if(isZoomed){
			GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
		}
		else{
			GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
		}
	} 
}
