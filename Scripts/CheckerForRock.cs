using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerForRock : MonoBehaviour
{
    public GameObject[] rocks;
    public GameObject parentForRocks;
    int rockIndex = 0;
    float rockPosX;
    float rockPosY;
    public GameObject checker;
    Vector3 oldPosition;

    void CreateRocks()
    {
        rockIndex = Random.Range(0, rocks.Length);
        GameObject newRock = Instantiate(rocks[rockIndex], parentForRocks.transform) as GameObject;
        oldPosition = checker.transform.localPosition;

        rockPosX = Random.Range(50f, 60f);
        rockPosY = 11f;
        
        newRock.transform.localPosition = new Vector3(oldPosition.x + rockPosX, oldPosition.y - rockPosY, oldPosition.z);
        checker.transform.localPosition = new Vector3(oldPosition.x + 92f, oldPosition.y, oldPosition.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            CreateRocks();

        }
    }
}
