using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPosition : MonoBehaviour
{
    public Transform player;
    public Text xposition;

    void Update()
    {
        if (player != null)
        {
            xposition.text = player.position.x.ToString("0");
        }
    }
}
