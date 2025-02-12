using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z) + offset;
    }
}
