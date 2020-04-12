using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public QuestHandler quest;

    public void ChangeScene()
    {
        if (quest.isLvl1)
        {
            if (OpeningElonTxt.sceneDone == true)
            {
                SceneManager.LoadScene("Level1");
            }
        }

        if (quest.isLvl2)
        {
            if(OpeningElonTxt.sceneDone == true)
            {
                SceneManager.LoadScene("Level2");
            }
        }
        if (quest.isLvl3)
        {
            if (OpeningElonTxt.sceneDone == true)
            {
                SceneManager.LoadScene("Level3");
            }
        }

        if (quest.isComplete)
        {
            if (OpeningElonTxt.sceneDone == true)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("OpeningCutScene");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
