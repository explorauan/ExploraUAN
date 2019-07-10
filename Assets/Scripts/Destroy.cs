using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public GameObject camera;

	public void DestroyObject(){
        GameObject.Destroy(camera);
	}
}
