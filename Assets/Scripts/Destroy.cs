using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Destroy : MonoBehaviour {

    private void Awake()
    {
        CameraDevice.Instance.Start();
    }

    public void DestroyObject(){
        if (GameObject.Find("Exit"))
        {
            CameraDevice.Instance.Stop();
            GameObject.Destroy(GameObject.Find("ARCamera"));
            GameObject.Destroy(GameObject.Find("Value"));
            GameObject.Destroy(GameObject.Find("TextureBufferCamera"));
            Debug.Log("Destruido");
        }
	}
}
