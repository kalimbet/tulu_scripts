using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumbersBeforeStart : MonoBehaviour
{
    Text numberText;
    string ready = "Ready!";
    string stady = "Stady!";
    string start = "Go!";
    float valueForStart = 3f;

    bool condition = true;

    // Start is called before the first frame update
    void Start()
    {
        numberText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreCalculation();
    }

    private void ScoreCalculation()
    {   
        if(condition == true)
        {
            valueForStart -= Time.deltaTime * 1;
            if (valueForStart > 0)
            {
                if (valueForStart > 2)
                {
                    numberText.text = ready;
                }
                else if (valueForStart > 1 && valueForStart < 2)
                {
                    numberText.text = stady;
                }
                else if (valueForStart > 0 && valueForStart < 1)
                {
                    numberText.text = start;
                }

            }
            else
            {
                condition = false;
                gameObject.SetActive(false);
            }
        }
        
    }
}
