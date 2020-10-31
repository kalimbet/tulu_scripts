using DragonBones;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroForMenu : MonoBehaviour
{
    public static bool statusMenu = false;
    public AudioSource dropSound;
    public AudioSource generalMusic;

    public Rigidbody2D ballRb;
    public GameObject stopObj;
    public GameObject helpMe;
    public GameObject playButton;
    public GameObject giftButton;
    public GameObject showMenuChecker;
    

    float value = 1.5f;
    bool heroText = false;
    int statusHero = 0;


    UnityArmatureComponent armatureComponent;
    Rigidbody2D heroRb;
    void Start()
    {
        heroRb = GetComponent<Rigidbody2D>();
        ballRb = ballRb.GetComponent<Rigidbody2D>();
        armatureComponent = GetComponent<UnityArmatureComponent>();
        //heroRb.transform.localPosition = new Vector2(-81,0);
    }

   

    private void FixedUpdate()
    {
        CheckStatus();
        if (statusMenu == true)
        {
            statusHero = 3;
            heroText = true;
            statusMenu = false;
        }

        TimeBeforDrop();
    }

    
    void CheckStatus()
    {
        switch (statusHero)
        {
            case 0:
                heroRb.velocity = new Vector2(10, heroRb.velocity.y);
                break;
            case 1:
                heroRb.velocity = new Vector2(0, 0);
                heroRb.gravityScale = 0f;
                armatureComponent.animation.FadeIn("Grap");
                statusHero = 4;
                break;
            case 2:
                heroRb.velocity = new Vector2(6, heroRb.velocity.y);
                break;
            case 3:
                armatureComponent.animation.FadeIn("Grap_2", 0, 2);
                ballRb.velocity = new Vector2(ballRb.velocity.x, -10);
                statusHero = 4;    
                break;
            case 4:
                break;
        }
    }


    void TimeBeforDrop()
    {

        if (heroText == true)
        {
            if(Variables.soundMusic == true) generalMusic.volume = 0.6f;
            
            value -= Time.deltaTime * 1;
            if (value > 0)
            {
                helpMe.SetActive(true);

            }
            else
            {
                if(Variables.soundSfx == true) dropSound.Play();

                heroRb.gravityScale = 1.6f;
                heroText = false;
                value = 1.5f;
                helpMe.SetActive(false);
                armatureComponent.animation.FadeIn("Jump"); 
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Stop")
        {
            statusHero = 1;
            stopObj.SetActive(false);
        }

        if (collision.gameObject.tag == "Slow")
        {
            statusHero = 2;
        }

        if (collision.gameObject.tag == "ShowMenu")
        {
            showMenuChecker.SetActive(false);
            playButton.SetActive(true);
            giftButton.SetActive(true);
        }
    }

}
