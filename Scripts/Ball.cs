using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject soundMovement;
    public AudioSource soundOnRock;
    public AudioSource soundDrop;

    bool one = true;

    private void Update()
    {
        if(Variables.inGame == false)
        {
            soundMovement.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Tree" && Variables.isLife == true)
        {
            if (Variables.soundSfx == true && Variables.inGame == true) 
            {
                if (Variables.soundSfx == true) { soundMovement.SetActive(true); }
                
                if (one == true)
                {
                    soundDrop.Play();
                    one = false;
                }
            }
        }



        if (collision.gameObject.tag == "Rock") 
        { 
            if(Variables.soundSfx == true && Variables.inGame == true && Variables.isLife == true)
                {
                    soundOnRock.Play(); 
                    one = true;
                }  
        }

        if (collision.gameObject.tag == "Tree")
        {
            if (Variables.soundSfx == true && Variables.inGame == true && Variables.isLife == true)
            {
                one = true;
            }
        }

    }
}
