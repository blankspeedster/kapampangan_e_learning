using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Module_1 : MonoBehaviour
{
    public InputField obj1, obj2, obj3, obj4, obj5;
    public string obj1Ans, obj2Ans, obj3Ans, obj4Ans, obj5Ans;
    public GameObject donePanel;
    public int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        donePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void confirmWords(){
        if(obj1.text == obj1Ans){
            score = score + 1;
        }

        if(obj2.text == obj2Ans){
            score = score + 1;
        }

        if(obj3.text == obj3Ans){
            score = score + 1;
        }

        if(obj4.text == obj4Ans){
            score = score + 1;
        }

        if(obj5.text == obj5Ans){
            score = score + 1;
        }
        
        scoreText.text = $"Yari ne ing pyalung. Ing kekang iskor: {score}";

        donePanel.SetActive(true);
        
    }
}
