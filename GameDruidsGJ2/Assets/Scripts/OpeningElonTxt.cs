using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// generator for ALL texts, not just opening*
public class OpeningElonTxt : MonoBehaviour
{
    // Opening
    //Welcome. Here at SpaceX, we’ve developed a “rocket” that will be able to
    //take you and a rover to Mars. The “ship” is equipped with amazing spatial
    //mobility along with other features that will help you if something
    //happens, but I wouldn’t worry about that. Just make sure to get the rover
    //to Mars and yourself back here safely. Good luck! (Click to continue)

    // Lvl2
    //Glad to see you here again. Now, for your second mission, I've located
    //another place to explore: Callisto, one of Jupiter's moons. Same procedure
    //as last time, but your trip will just be a bit longer. Good luck! (Click
    //to continue)

    // Lvl3
    //Nice work. Now get ready to get back out there because there's another
    //place that has captured my interest: Titan, Saturn's largest moon. You 
    //know the drill by now. Just be very careful here. This is the farthest we 
    //have ever dared to explore. Good luck! (Click to continue)

    // End
    //Well I can see why you're my secretary after all. I applaud you for how
    //far you've come, bringing us, SpaceX, along with you. I look forward to
    //exploring more planets with you in the future. Thank you. (Click to finish)


    public GameObject rover;
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";

    public float showRoverTimer = 11f;

    public static bool sceneDone;

    void Start()
    {
        sceneDone = false;

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
