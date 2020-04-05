using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningElonTxt : MonoBehaviour
{
    //Welcome. Here at SpaceX, we’ve developed a “rocket” that will be able to
    //take you and a rover to Mars. The “ship” is equipped with amazing spatial
    //mobility along with other features that will help you if something
    //happens, but I wouldn’t worry about that. Just make sure to get the rover
    //to Mars and yourself back here safely. Good Luck! (Click to continue)

    public GameObject rover;
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";

    public float showRoverTimer = 11f;

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
