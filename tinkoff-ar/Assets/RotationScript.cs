using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    float angle;
    
    void Update()
    {
        angle += Time.deltaTime * 10f;
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }
}
