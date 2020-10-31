using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsGUI : MonoBehaviour
{
    Text coinsText;

    // Start is called before the first frame update
    void Start()
    {
        coinsText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = Variables.coins.ToString() + " $";
    }
}
