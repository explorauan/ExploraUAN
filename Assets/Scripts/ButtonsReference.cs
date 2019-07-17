using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsReference : MonoBehaviour {

    public string button;

    public string Asignation(string button)
    {
        if (GameObject.Find("Paseo"))
        {
            button = "P";
        }
        else if (GameObject.Find("Murales"))
        {
            button = "M";
        }
        else if (GameObject.Find("Libre"))
        {
            button = "L";
        }

        Debug.Log(button);
        return button;
    }
}
