using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatforms : MonoBehaviour
{
    bool state = true;

    private void Update()
    {
        if(Variables.inGame == true && state == true)
        {
            Destroy(gameObject, 16);
            state = false;
        }
    }
}
