using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	public void DestroyObject(){
        if (GameObject.Find("Exit"))
        {
            GameObject.Destroy(GameObject.Find("ARCamera"));
            Debug.Log("Destruido");
        }
	}
}
