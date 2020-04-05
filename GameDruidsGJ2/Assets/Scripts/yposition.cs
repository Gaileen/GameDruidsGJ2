using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class yposition : MonoBehaviour
{
    public Transform player;
    public Text ypos;

    void Update()
    {
        if (player != null)
        {
            ypos.text = player.position.y.ToString("0");
        }

    }
}
