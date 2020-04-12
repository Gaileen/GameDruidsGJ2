using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float speed = 1f;

    public SpriteRenderer player;

    public QuestHandler quest;

    private void Start()
    {
        // start at Earth
        transform.position = new Vector3(-.6f, 0 , -10);
    }

    void Update()
    {
        // get to destination
        if (quest.roverPlaced == false)
        {
            transform.position += speed * Vector3.right * Time.deltaTime;

            // stop at destination
            if (quest.isLvl1)
            {
                if (transform.position.x >= 20.2)
                {
                    speed = 0f;
                }
            }

            if (quest.isLvl2)
            {
                if (transform.position.x >= 50)
                {
                    speed = 0f;
                }
            }

            if (quest.isLvl3)
            {
                if (transform.position.x >= 99)
                {
                    speed = 0f;
                }
            }
        }

        // get home
        if (quest.roverPlaced)
        {
            speed = 1f;
            transform.position += speed * Vector3.left * Time.deltaTime;

            // stop at Earth
            if (transform.position.x <= -.5)
            {
                transform.position = new Vector3(-.6f, 0, -10);
            }
        }
    }
}
