using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadTest : MonoBehaviour {

    public GameObject loadPanel;
    public Slider loadBar;
    public Text charge;

    private AsyncOperation asyn;

    /*private void Awake()
    {
        loadBar.value = 0f;
    }*/

    public void ClickCarga()
    {
        loadPanel.SetActive(true);
        StartCoroutine(LoadSlider("Camara"));
    }

    IEnumerator LoadSlider(string scene)
    {
        asyn = Application.LoadLevelAsync("Camara");

        while(!asyn.isDone)
        {
            loadBar.value = Mathf.Clamp01(asyn.progress / .9f) * 100;
            charge.text = loadBar.value.ToString() + "%";
            yield return null;
        }

        /*if(asyn.isDone == true)
        {
            StopCoroutine(LoadSlider("Camara"));
        }*/
    }
}
