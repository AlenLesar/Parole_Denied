using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LvlLoader02 : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public Text nivo01;
    public Text nivo02;
    public Text nivo03;
    public Text izlaz;


    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);
        if (nivo01 && nivo02 && nivo03 && izlaz) {
            nivo01.enabled = false;
            nivo02.enabled = false;
            nivo03.enabled = false;
            izlaz.enabled = false;
        }
       

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = progress * 100f + "%";

            yield return null;
        }
    }
}