using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    private float iniTime = 0.0f;

    public GameObject años;
    public GameObject escudo;
    public GameObject logo;
    public float endTime;
	
	// Update is called once per frame
	void Update () {
        iniTime += Time.deltaTime;

        if (iniTime >= 4.0f && iniTime <= 7.9f)
        {
            años.SetActive(false);
            escudo.SetActive(true);
            logo.SetActive(false);
        }
        else if (iniTime >= 8.0f && iniTime <= endTime)
        {
            años.SetActive(false);
            escudo.SetActive(false);
            logo.SetActive(true);
        }
        else if (iniTime >= endTime)
        {
            Application.LoadLevel("Inicio");
        }
	}
}
