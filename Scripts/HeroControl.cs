using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleInputNamespace;
using DragonBones;

public class HeroControl : MonoBehaviour {

    public static bool deadAds = false;
    public string jumpButton = "Jump";
    public AudioSource jumpSound;
    public AudioSource jumpSound2;
    public AudioSource soundDead;
    public AudioSource soundDeadG;
    public AudioSource soundDrop;
    float speed = 4F;
    float speedRight = 6f;
    float forceJump = 12F;
    bool deadForAnim = false;
    bool isOnBall;
    float timeBeforeDead = 2;
    bool soundState = true;
    int jumpSoundRandom;
    Rigidbody2D heroRb;
    UnityArmatureComponent armatureComponent;
    
    // Use this for initialization
    void Start () 
    {
        armatureComponent = GetComponent<UnityArmatureComponent>();
        heroRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () 
    {
        if(Variables.inGame == true)
        {
            CheckJump();
            TimeBeforeDead();
        }
        

    }

    private void FixedUpdate()
    {
        if (Variables.inGame == true) { Movement(); }
    }

    private void Movement()
    {

        float movDirection = SimpleInput.GetAxis("Horizontal");
        if (movDirection > 0) { movDirection *= speed + speedRight; }
        else { movDirection *= speed; }
        heroRb.velocity = new Vector2(movDirection, heroRb.velocity.y);
    }
  

 
    public void CheckJump()
    {
        if (SimpleInput.GetButtonDown(jumpButton) && isOnBall == true && Variables.isLife == true)
        {
            jumpSoundRandom = Random.Range(1, 3);
            if (Variables.soundSfx == true && jumpSoundRandom == 1) { jumpSound.Play(); }
            else if (Variables.soundSfx == true && jumpSoundRandom == 2) { jumpSound2.Play(); }

            armatureComponent.animation.FadeIn("Jump");
            heroRb.velocity = new Vector2(0, 0);
            heroRb.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
            isOnBall = false;
        }

    }

    private void HeroDead()
    {
        if (Variables.isLife == true)
        {
            heroRb.velocity = new Vector2(0, 0);
            heroRb.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
            armatureComponent.animation.FadeIn("Dead", 0, 1);
            isOnBall = false;
            speed = 0;
            speedRight = 0;
            heroRb.freezeRotation = false;
            heroRb.drag = 1.2f;
            deadForAnim = true;
            Variables.numberOfDead++;
            Variables.numberForAds++;
            Variables.isLife = false;
            Variables.menuStatus = 0;
            Variables.speedLevel = 0f;
            LoadSave.condition = true;
        }

    }
     void TimeBeforeDead()
    {
        if (deadForAnim == true)
        {
            timeBeforeDead -= Time.deltaTime;
            if (timeBeforeDead > 0) { }
            else
            {         
                Variables.coinsMultiply = 1;
                Variables.inGame = false;
                Time.timeScale = 0f;
                deadAds = true;
                deadForAnim = false;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyEagle")
        {
            HeroDead();
            Handheld.Vibrate();
            if (Variables.soundSfx == true && soundState == true)
            {
                soundDead.Play();
                soundState = false;
            }
        }

        if (collision.gameObject.tag == "Ball" && Variables.isLife == true)
        {
            if(Variables.soundSfx == true && Variables.inGame == true) { soundDrop.Play(); }

            armatureComponent.animation.FadeIn("Run");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Rock" || collision.gameObject.tag == "Tree")
        {
            HeroDead();
            if (Variables.soundSfx == true && soundState == true)
            {
                soundDeadG.Play();
                soundState = false;
            }
        }

       
        if (collision.gameObject.tag == "Ball") { isOnBall = true; }
    }

}

