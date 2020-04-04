using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPosition : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text xposition;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xposition.text = player.position.x.ToString("0");
    }
}
