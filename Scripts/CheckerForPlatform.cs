using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerForPlatform : MonoBehaviour
{
    public GameObject[] platforms;
    int groundIndex = 0;
    Vector3 oldPosition;
    public GameObject parentForPlatforms;
    public GameObject checker;

    void CreateGround()
    {
        groundIndex = Random.Range(0, platforms.Length);
        GameObject newPlatform = Instantiate(platforms[groundIndex], parentForPlatforms.transform) as GameObject;
        oldPosition = checker.transform.localPosition;
        newPlatform.transform.localPosition = new Vector3(oldPosition.x + 184f, oldPosition.y, oldPosition.z);
        checker.transform.localPosition = new Vector3(oldPosition.x + 92f, oldPosition.y, oldPosition.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            CreateGround();
        }
    }

}
