using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestHandler : MonoBehaviour
{
    public GameObject rover;

    public bool roverPlaced;
    public bool returnEarth;

    public bool isLvl1;
    public bool isLvl2;
    public bool isLvl3;
    public bool isComplete = false;

    public Transform player;
    public Transform earth;
    public Transform mars;
    public Transform callisto;
    public Transform titan;

    void Start()
    {
        // (re)setup
        rover.SetActive(false);
        roverPlaced = false;
        returnEarth = false; // assuming roverPlaced when true

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
            isLvl1 = true;
            isLvl2 = false;
            isLvl3 = false;
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
        {
            isLvl2 = true;
            isLvl1 = false;
            isLvl3 = false;
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3"))
        {
            isLvl3 = true;
            isLvl2 = false;
            isLvl1 = false;
        }
    }

    void Update()
    {
        if(player != null)
        { 
            if (isLvl1)
            {
                // if player on Mars, show Rover & roverPlaced = true
                if (player.position.x >= mars.position.x)
                {
                    rover.SetActive(true);
                    roverPlaced = true;

                    isLvl2 = true;
                    isLvl1 = false;
                }
            }

            if (isLvl2)
            {
                if (player.position.x >= callisto.position.x)
                {
                    rover.SetActive(true);
                    roverPlaced = true;

                    isLvl3 = true;
                    isLvl2 = false;
                }
            }

            if (isLvl3)
            {
                if (player.position.x >= titan.position.x)
                {
                    rover.SetActive(true);
                    roverPlaced = true;

                    isComplete = true;
                    isLvl3 = false;
                }
            }

            if (roverPlaced)
            {
                if (player.position.x <= earth.position.x)
                {
                    returnEarth = true;
                }
            }

            if (roverPlaced && returnEarth)
            {
                // change scene to Elon txt
                if (isLvl2)
                {
                    SceneManager.LoadScene("ElonLvl2Txt");
                }
                if (isLvl3)
                {
                    SceneManager.LoadScene("ElonLvl3Txt");
                }

                // Victory
                if (isComplete)
                {
                    SceneManager.LoadScene("ElonLastTxt");
                }
            }

        }
    }
}
