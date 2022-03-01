using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letterCompleter : MonoBehaviour
{
    public int maxLetterCount, currentCount = 0;
    public string thingName;
    public AudioSource complete, clickSound;
    public GameObject confetti, nextGameButton, nextGameObjects, currentGameObjects;

    // Start is called before the first frame update
    void Start()
    {
        confetti.SetActive(false);
        PlayerPrefs.SetInt(thingName,currentCount);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt(thingName) == maxLetterCount)
        {
            confetti.SetActive(true);
            nextGameButton.SetActive(true);
            PlayerPrefs.SetInt(thingName, 0);
            complete.Play();
        }
    }

    //nextGameObjects
    public void showNextGame()
    {
        clickSound.Play();
        nextGameButton.SetActive(false);
        currentGameObjects.SetActive(false);
        nextGameObjects.SetActive(true);
    }
}
