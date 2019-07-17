using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomText : MonoBehaviour {

    public GameObject textoA;
    public GameObject textoB;
    public GameObject textoC;
    public GameObject textoD;

    private int random;

    private void Awake()
    {
        random = 0;

        textoA.SetActive(false);
        textoB.SetActive(false);
        textoC.SetActive(false);
        textoD.SetActive(false);
    }

    public void RandomValue()
    {
        random = Random.Range(1, 5);

        switch (random)
        {
            case 1:
                textoA.SetActive(true);
                textoB.SetActive(false);
                textoC.SetActive(false);
                textoD.SetActive(false);
                break;
            case 2:
                textoB.SetActive(true);
                textoA.SetActive(false);
                textoC.SetActive(false);
                textoD.SetActive(false);
                break;
            case 3:
                textoC.SetActive(true);
                textoA.SetActive(false);
                textoB.SetActive(false);
                textoD.SetActive(false);
                break;
            case 4:
                textoD.SetActive(true);
                textoA.SetActive(false);
                textoB.SetActive(false);
                textoC.SetActive(false);
                break;
        }
    }
}
