using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public void Awake()
    {
        GameObject.DontDestroyOnLoad(GameObject.Find("ARCamera"));
        //Application.LoadLevel(Application.loadedLevel);
    }

    public void DestroyObject(){
        if (GameObject.Find("Exit"))
        {
            GameObject.Destroy(GameObject.Find("ARCamera"));
            GameObject.Destroy(GameObject.Find("Value"));
            Debug.Log("Destruido");
        }
	}
}
