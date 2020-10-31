using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsMultiplay : MonoBehaviour
{
    Text multiplyText;

    void Start()
    {
        multiplyText = GetComponent<Text>();
    }


    void Update()
    {
        multiplyText.text = "x" + Variables.coinsMultiply.ToString();
    }

}
