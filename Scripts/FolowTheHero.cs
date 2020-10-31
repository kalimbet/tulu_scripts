using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowTheHero : MonoBehaviour
{

    public GameObject hero;
    

    void Update()
    {
        Vector3 position = hero.transform.position;
        position.y += 0;
        transform.position = position;
    }


}
