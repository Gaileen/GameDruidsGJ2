using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public int speed;

    void Update()
    {
        transform.position += speed * Vector3.right * Time.deltaTime;
    }
}
