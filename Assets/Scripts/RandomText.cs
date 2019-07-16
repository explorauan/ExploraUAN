using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomText : MonoBehaviour {

    public GameObject textoA;
    public GameObject textoB;
    public GameObject textoC;
    public GameObject textoD;
    public GameObject textoE;

    private int random;

    private void Start()
    {
        random = 0;
    }

    public void RandomValue()
    {
        random = Random.Range(1, 6);

        switch (random)
        {
            case 1:
                textoA.SetActive(true);
                break;
            case 2:
                textoB.SetActive(true);
                break;
            case 3:
                textoC.SetActive(true);
                break;
            case 4:
                textoD.SetActive(true);
                break;
            case 5:
                textoE.SetActive(true);
                break;
        }
    }
}
