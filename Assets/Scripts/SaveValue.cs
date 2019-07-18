using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveValue : MonoBehaviour {

    public static string value = " ";

    // Use this for initialization

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        value = null;
    }

    public void Paseo()
    {
        value = "P";
        Debug.Log(value);
    }

    public void Murales()
    {
        value = "M";
        Debug.Log(value);
    }

    public void Libre()
    {
        value = "L";
        Debug.Log(value);
    }
}
