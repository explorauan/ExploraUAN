using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectValue : MonoBehaviour {

    public string value;
    public GameObject paseo;
    public GameObject murales;

    // Use this for initialization
    void Start () {
        value = SaveValue.value;

        if (value == "P")
        {
            paseo.SetActive(true);
            murales.SetActive(false);
        }
        else if (value == "M")
        {
            paseo.SetActive(false);
            murales.SetActive(true);
        }
        else
        {
            paseo.SetActive(true);
            murales.SetActive(true);
        }
    }
}
