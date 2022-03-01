using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour
{   
    public GameObject menuOptions, title, tapToStart;
    public AudioSource clickSound;
    // Start is called before the first frame update
    void Start()
    {
        menuOptions.SetActive(false);
        title.SetActive(true);
        tapToStart.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    //Tap Start
    public void TapStart()
    {
        menuOptions.SetActive(true);
        title.SetActive(false);
        tapToStart.SetActive(false);
        clickSound.Play();
    }

    // Play Module 1
    public void playModule1()
    {
        SceneManager.LoadScene("Modyul_1_Scene");
    }
}
