using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtainButton : MonoBehaviour {

    public ButtonsReference value;

	// Use this for initialization
	void Start () {
        value = new ButtonsReference();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(value);
	}
}
