using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordDistance : MonoBehaviour
{
    Text recordDistance;

    void Start()
    {
        recordDistance = GetComponent<Text>();
    }

    void Update()
    {
        RecordCalculation();
        recordDistance.text = Variables.recordDistance + " m";
    }

    void RecordCalculation()
    {
        if (Variables.recordDistance < GameScore.valueScore)
        {
            Variables.recordDistance = GameScore.valueScore;
        }
    }
}
