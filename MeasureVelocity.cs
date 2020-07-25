using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureVelocity : MonoBehaviour
{
    [SerializeField] Vector3 coords;
    [SerializeField] float speed;
    Vector3 oldCoords;

    void FixedUpdate()
    {
        coords = transform.position;
        speed = Vector3.Distance(coords, oldCoords) / 50f;
        print(speed + " m/s");
        oldCoords = coords;
    }
}
