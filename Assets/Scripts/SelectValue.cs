using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectValue : MonoBehaviour {

    public string value;
	// Use this for initialization
	void Start () {
        value = SaveValue.value;
	}
	
    public void Selected()
    {
        if(value == "P")
        {
            GameObject.Find("Paseo").gameObject.SetActive(true);
            GameObject.Find("Murales").gameObject.SetActive(false);
        }
        else if(value == "M")
        {
            GameObject.Find("Paseo").gameObject.SetActive(false);
            GameObject.Find("Murales").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("Paseo").gameObject.SetActive(true);
            GameObject.Find("Murales").gameObject.SetActive(true);
        }
    }
}
