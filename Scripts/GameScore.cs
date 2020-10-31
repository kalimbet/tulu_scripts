using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameScore : MonoBehaviour
{
    Text scoreText;
    public static int valueScore = 0;
    float timeFromStart = 0f;
    float timeForScore = 4f;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void Update()
    {

        if(Variables.inGame == false)
        {
            scoreText.text = valueScore.ToString() + " m";
        }
        else
        {
            ScoreCalculation();
            scoreText.text = valueScore.ToString() + " m";
        }
        

    }

    private void ScoreCalculation()
    {
        timeFromStart += Time.deltaTime;
        if(timeFromStart > timeForScore)
        {
            valueScore += 1;
            timeForScore += 1f;
        }
    }
}
