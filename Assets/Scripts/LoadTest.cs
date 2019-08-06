using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadTest : MonoBehaviour {

    public GameObject loadPanel;
    public Slider loadBar;
    public Text charge;
    private float speed;

    private AsyncOperation asyn;

    private void Awake()
    {
        loadBar.value = 0f;
        
    }

    public void ClickCarga()
    {
        loadPanel.SetActive(true);
        StartCoroutine(LoadSlider());
    }

    IEnumerator LoadSlider()
    {
        //asyn = SceneManager.LoadSceneAsync("Camara");

        while (loadBar.value <= 100) //  !asyn.isDone
        {
            //Debug.Log(asyn.allowSceneActivation);
            speed = speed + 1;
            loadBar.value = speed; //Mathf.Clamp01(asyn.progress / 0.9f)
            charge.text = loadBar.value.ToString() + "%";
            if (loadBar.value == 100)
            {
                Application.LoadLevel("Camara");
            }
            yield return null;
        }
    }
}
