﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{

    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * Variables.speedLevel * Time.deltaTime);
    }
}
