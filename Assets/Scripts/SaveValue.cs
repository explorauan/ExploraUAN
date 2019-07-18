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
    }

    public void Murales()
    {
        value = "M";
    }

    public void Libre()
    {
        value = "L";
    }
}
