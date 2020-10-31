using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour {

    [SerializeField]
    private float spead = 2.0F;
    
    [SerializeField]
    private Transform target;

    float positionZ = 20F;

    private void LateUpdate()
    {
        Vector3 position = target.position;
        position.z = -positionZ;
        position.x += 0f;
        position.y += 3f;
        transform.position = Vector3.Lerp(transform.position, position, spead * Time.deltaTime);
    }

}
