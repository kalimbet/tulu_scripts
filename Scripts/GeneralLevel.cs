using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GeneralLevel : MonoBehaviour
{
    public GameObject level;

    public GameObject parentEnemyEagle;
    public GameObject enemySpawnLeft;
    public GameObject enemySpawnRight;
    public GameObject enemyEagle;


    public GameObject hero;
    public GameObject ball;
    float heroT;
    float ballT;

    int difficul = 1;
    float valueForEnemy = 10f;

    float valueForStart = 3f;
    bool levelPreparedCondition = true;

    float eagleIntervalMin = 5f;
    float eagleIntervalMax = 15f;

    int posRot;
    

    // Start is called before the first frame update
    void Start()
    {
        PrepareGame();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Variables.inGame == true)
        {
            TimerForStart();
        }
        if (Variables.inGame == true)
        {
            AddEnemyWithInterval(eagleIntervalMin, eagleIntervalMax);
        }
        Difficult();
    }


    void PrepareGame()
    {
        heroT = hero.GetComponent<Rigidbody2D>().gravityScale;
        hero.GetComponent<Rigidbody2D>().gravityScale = 0;
        ballT = ball.GetComponent<Rigidbody2D>().gravityScale;
        ball.GetComponent<Rigidbody2D>().gravityScale = 0;
        
    }

    void TimerForStart()
    {

        if (levelPreparedCondition == true)
        {
         
            valueForStart -= Time.deltaTime * 1;
            if (valueForStart > 0)
            {

            }
            else
            {
                level.GetComponent<GroundScript>().enabled = true;
                hero.GetComponent<HeroControl>().enabled = true;
                hero.GetComponent<Rigidbody2D>().gravityScale = heroT;
                ball.GetComponent<Rigidbody2D>().gravityScale = ballT;
                levelPreparedCondition = false;
            }
        }



    }



    private void CreateEnemyEagle()
    {
        posRot = Random.Range(1, 3);
        
        GameObject newEnemyEagle = Instantiate(enemyEagle, parentEnemyEagle.transform) as GameObject;
        if (posRot == 1)
        {
            int enemyPositionX = Random.Range(-4, 4);
            newEnemyEagle.transform.position = new Vector3(enemySpawnRight.transform.position.x + enemyPositionX, enemySpawnRight.transform.position.y, enemySpawnRight.transform.position.z);
            //newEnemyEagle.transform.localRotation = Quaternion.Euler(0, 0, 0);
            newEnemyEagle.GetComponent<EnemyEagle>().positionRotation = posRot;
            newEnemyEagle.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            int enemyPositionX = Random.Range(-4, 4);
            newEnemyEagle.transform.position = new Vector3(enemySpawnLeft.transform.position.x - enemyPositionX, enemySpawnLeft.transform.position.y, enemySpawnLeft.transform.position.z);
            //newEnemyEagle.transform.localRotation = Quaternion.Euler(0, 180, 0);
            newEnemyEagle.GetComponent<EnemyEagle>().positionRotation = posRot;
            newEnemyEagle.GetComponent<SpriteRenderer>().flipX = true;
        }
   
    }

    void Difficult()
    {

        if(GameScore.valueScore == 20 && difficul == 1)
        {
            //ball.GetComponent<Rigidbody2D>().gravityScale = 1.5f;
            //EnemyEagle.sprint = 10f;
            difficul = 2;
            eagleIntervalMax = 0;
            eagleIntervalMax = 10f;
        }

        if (GameScore.valueScore == 30 && difficul == 2)
        {
            //ball.GetComponent<Rigidbody2D>().gravityScale = 1.5f;
            //EnemyEagle.sprint = 10f;
            difficul = 3;
            eagleIntervalMax = 0;
            eagleIntervalMax = 2f;
            Variables.coinsMultiply = 2;
        }

        if (GameScore.valueScore == 90 && difficul == 2)
        {
            difficul = 4;
            Variables.coinsMultiply = 4;
        }
    }


    private void AddEnemyWithInterval(float timeFrom, float timeUntil)
    {
        
        valueForEnemy -= Time.deltaTime * 1;
        if (valueForEnemy < 0)
        {
            
            valueForEnemy = Random.Range(timeFrom, timeUntil);
            CreateEnemyEagle();
        }
    }
}
