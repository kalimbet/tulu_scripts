using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEagle : MonoBehaviour
{
    float speed = 6f;
    public static float sprint = 6f;
    float timeDestroy = 5f;
    bool target = false;

    public Animator enemyAnim;
    public int positionRotation;
    Vector2 direction;

    public AudioSource enemySound;
    
    void Start()
    {
        //enemySound = GetComponent<AudioSource>();
        //enemyAnim = GetComponent<Animator>();
        Destroy(gameObject, timeDestroy);
    }

    private void Update()
    {
        if (target == false)
        {
            EnenmyMovement();
        }
        else
        {
            EnemySprint();
        }
    }

    private void EnenmyMovement()
    {

        if (positionRotation == 1)
        {
            direction = new Vector2(1.5f, -3f);
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else
        {
            direction = new Vector2(1.1f, -3f);
            transform.Translate(direction * speed * Time.deltaTime);
        }
        
    }

    private void EnemySprint()
    {
        if (positionRotation == 1){
            direction = new Vector2(-8f, -2f);
            transform.Translate(direction * sprint * Time.deltaTime);
        }
        else
        {
            
            direction = new Vector2(8f, -2f);
            transform.Translate(direction * sprint * Time.deltaTime);
        }

        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Target"){
            enemyAnim.SetInteger("State", 2);
            target = true;

            if (Variables.soundSfx == true)
            {
                enemySound.Play();
            }
        }
    }
}
