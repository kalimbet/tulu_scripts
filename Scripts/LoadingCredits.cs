using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingCredits : MonoBehaviour
{
    public Text loadingText;
    float timeStart = 1f;


    private void Update()
    {
        timeStart -= Time.deltaTime;
        if (timeStart > 0) loadingText.text = "Loading...";
        else SceneManager.LoadScene("Credits");
    }
}
