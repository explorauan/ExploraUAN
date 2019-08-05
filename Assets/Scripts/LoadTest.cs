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
        StartCoroutine(LoadSlider());
        Debug.Log("isDone: " + asyn.isDone);
    }

    IEnumerator LoadSlider()
    {
        asyn = Application.LoadLevelAsync("Camara");
        asyn.allowSceneActivation = false;

        while(!asyn.isDone) // loadBar.value < 100
        {
            float progress = Mathf.Clamp01(asyn.progress / 0.9f);
            loadBar.value = progress * 100;
            charge.text = loadBar.value.ToString() + "%";

            if (asyn.progress == 0.9f)
            {
                asyn.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
