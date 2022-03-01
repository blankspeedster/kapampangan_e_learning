using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidedChecker : MonoBehaviour
{
    public GameObject letterBox;
    public string thingName;
    public AudioSource correct, wrong;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collide)
    {
        Debug.Log(collide.collider.gameObject.name);
        if(collide.collider.gameObject.name == gameObject.name)
        {
            int currentCount = PlayerPrefs.GetInt(thingName);
            currentCount++;
            PlayerPrefs.SetInt(thingName,currentCount);
             wrong.Stop();
            correct.Play();
            //
            letterBox.SetActive(true);
            gameObject.SetActive(false);
            collide.gameObject.SetActive(false);
        }
        else
        {
            wrong.Play();
        }
    }
}
