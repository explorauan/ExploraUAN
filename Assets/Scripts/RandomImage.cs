using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomImage : MonoBehaviour {

    public GameObject fondoA;
    public GameObject fondoB;

    private int random;

    private void Awake()
    {
        random = 0;
        fondoA.SetActive(false);
        fondoB.SetActive(false);
    }

    // Update is called once per frame
    public void RandomValue()
    {
        random = Random.Range(1, 3);

        if (random == 1)
        {
            fondoA.SetActive(true);
            fondoB.SetActive(false);
        }
        else if(random == 2)
        {
            fondoB.SetActive(true);
            fondoA.SetActive(false);
        }
    }
}
