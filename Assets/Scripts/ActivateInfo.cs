using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateInfo : MonoBehaviour {

    public GameObject infoPanel;
    public GameObject continueButton;

    private float timer = 0.0f;

    public void Activate()
    {
        infoPanel.SetActive(true);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 3.0f)
        {
            continueButton.SetActive(true);
        }
    }
}
