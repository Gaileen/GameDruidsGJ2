using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class yposition : MonoBehaviour
{

    public Transform player;
    public Text ypos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ypos.text = player.position.y.ToString("0");

    }
}
