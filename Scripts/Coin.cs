using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Rigidbody2D coin;
    Vector2 coinPosition;
    float distance = 5;

    public AudioSource coinSound;

    void Start()
    {
        //coin = GetComponent<Rigidbody2D>();
        coinPosition = gameObject.transform.localPosition;
    }

    private void Update()
    {
        coin.velocity = new Vector2(coin.velocity.x, distance);
        moveCoin();
    }



    void moveCoin()
    {
        if(coin.transform.localPosition.y > coinPosition.y + 3)
        {
            distance = -5;
        }else if(coin.transform.localPosition.y < coinPosition.y - 3)
        {
            distance = 5;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0.05f);
            Variables.coins += 5 * Variables.coinsMultiply;
            if (Variables.soundSfx == true) coinSound.Play();
        }
    }


}
