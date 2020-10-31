using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerForCoins : MonoBehaviour
{

    public GameObject[] coins;
    int coinsIndex = 0;
    Vector3 oldPosition;
    public GameObject parentForCoins;
    public GameObject checker;

    void CreateCoin()
    {
        coinsIndex = Random.Range(0, coins.Length);
        GameObject newPlatform = Instantiate(coins[coinsIndex], parentForCoins.transform) as GameObject;
        oldPosition = checker.transform.localPosition;
        newPlatform.transform.localPosition = new Vector3(oldPosition.x + 20f, oldPosition.y, oldPosition.z);
        checker.transform.localPosition = new Vector3(oldPosition.x + 20f, oldPosition.y, oldPosition.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            CreateCoin();
        }
    }
}
