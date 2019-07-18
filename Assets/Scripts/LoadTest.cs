using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadTest : MonoBehaviour {

    public GameObject loadPanel;
    public Slider loadBar;
    public Text charge;

    private AsyncOperation asyn;

    private void Awake()
    {
        loadBar.value = 0f;
    }

    public void ClickCarga()
    {
        loadPanel.SetActive(true);
        StartCoroutine(LoadSlider("Camara"));
    }

    IEnumerator LoadSlider(string scene)
    {
        asyn = Application.LoadLevelAsync("Camara");

        while(!asyn.isDone) // loadBar.value < 100
        {
            float progress = Mathf.Clamp01(asyn.progress / .9f);
            loadBar.value = progress * 100;
            charge.text = loadBar.value.ToString() + "%";

            if (loadBar.value == 100)
            {
                asyn.allowSceneActivation = true;
                progress = 0f;
                Debug.Log("Is Done, bitch!" + progress);
            }
            yield return null;
        }
    }
}
