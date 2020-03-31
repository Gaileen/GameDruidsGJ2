using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningElonTxt : MonoBehaviour
{
    //Greetings, new secretary. For your first task, you're going to take command 
    //of my new rocket to bring this new rover over to Mars. Don't crash into 
    //anything and be careful of UFOs. Good Luck! (Click to continue)

    public GameObject rover;
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";

    public float showRoverTimer = 10f;

    public static bool sceneDone = false;

    void Start()
    {
        rover.SetActive(false);
        StartCoroutine(ShowText());

        StartCoroutine(ShowRover());
    }

    void Update()
    {
        if (currentText.Equals(fullText))
        {
            sceneDone = true;
        }
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator ShowRover()
    {
        yield return new WaitForSeconds(showRoverTimer);
        rover.SetActive(true);
    }
}
