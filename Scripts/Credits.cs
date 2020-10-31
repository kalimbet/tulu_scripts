using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public string creditsExitButton = "CreditsExit";

    public GameObject cometObj;
    public GameObject creditsText;
    public GameObject finalText;
    public GameObject exitButton;
    public GameObject musicPlay;
    public GameObject soundButton;
    float speedCreditsText = 1.5f;
    float speedComet = 4f;


    float valueForStart = 25f;
    float valueForFinalCredits = 77f;

    bool cometActive = false;
    bool creditsTextActive = true;
    bool creditsFinalActive = true;

    void Update()
    {
        ResetComet();
        moveComet();
        moveCreditsText();
        LastCredits();

        if (Variables.soundSfx == true) soundButton.SetActive(true);
        else soundButton.SetActive(false);

        if (SimpleInput.GetButtonUp(creditsExitButton)) { exitButton.SetActive(false); SceneManager.LoadScene("Loading"); }
    }

    void moveComet()
    {
        if(cometActive == true) cometObj.transform.Translate(Vector3.left * speedComet * Time.deltaTime);
        else cometObj.transform.position = new Vector3(15.9f, 61.1f, 0);

    }

    void moveCreditsText() { if (creditsTextActive == true) creditsText.transform.Translate(Vector3.up * speedCreditsText * Time.deltaTime); }


    private void ResetComet()
    {
        if(creditsTextActive == true)
        {
            valueForStart -= Time.deltaTime * 1;
            if (valueForStart > 0)
            {
                if(valueForStart < 24 && Variables.soundMusic == true)
                {
                    musicPlay.SetActive(true);
                }
                cometActive = true;
            }
            else
            {
                cometActive = false;
                valueForStart = 25f;
            }
        }

    }

    private void LastCredits()
    {
        if(creditsFinalActive == true)
        {
            valueForFinalCredits -= Time.deltaTime * 1;
            if (valueForFinalCredits > 0)
            {
                if (valueForFinalCredits < 40)
                {
                    exitButton.SetActive(true);
                }

            }
            else
            {
                finalText.SetActive(true);
                creditsFinalActive = false;
                creditsTextActive = false;
            }
        }


    }

}
