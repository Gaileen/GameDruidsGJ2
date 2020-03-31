using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float maxSpeed = 10f;
    public float rotSpeed = 180f;

    public float shipBoundaryRadius = 0.5f;

    void Update()
    {
        // rotate
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot; 

        // move
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime);
        pos += rot * velocity;

        // vert boundaries
        if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }
        if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        }

        // horiz boundaries
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float screenWidth = Camera.main.orthographicSize * screenRatio; //orthoSize making ship respawn??
        //if (pos.x + shipBoundaryRadius > widthOrtho)
        //{
        //    pos.x = widthOrtho - shipBoundaryRadius;
        //}
        //if (pos.x - shipBoundaryRadius < -widthOrtho)
        //{
        //    pos.x = -widthOrtho + shipBoundaryRadius;
        //}

        transform.position = pos;
    }
}
