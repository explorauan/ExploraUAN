using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomBtnmen : MonoBehaviour {
	
//Scale variable
	public GameObject scale;
	public GUITexture zoomOut;

	//Variables from speed scale n' status of scale
	public float scaleSpeed = 0.02f;
	bool scaleStatus = false;

	public void Scalation(){
		if(scaleStatus==false){
			scaleStatus = true;
		}
		else{
			scaleStatus = false;
		}
	}

	// Update is called once per frame
	void Update () {
		foreach(Touch touch in Input.touches){
			if(touch.phase == TouchPhase.Began && zoomOut.HitTest(touch.position)){
				if(scaleStatus==true){
					//This code line decrease the y's position from gameobject
					scale.transform.localPosition -= new Vector3(0, scaleSpeed, 0);
				}
			}
			else if(touch.phase == TouchPhase.Ended){
				scaleStatus = false;
			}
		}
	}
}
