using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene()
    {
        if(OpeningElonTxt.sceneDone == true)
        { 
            SceneManager.LoadScene("Level1");
        }
    }
}
