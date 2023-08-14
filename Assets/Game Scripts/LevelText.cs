using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public Text levelText; //The text that will show up
    public static int levelCounter = 1; //Sets the beginning level to 1

    void Start()
    {
        levelText = GetComponent<Text> (); //making a reference to the levelText gameObject
    }

    void Update()
    {  

        levelText.text = "Level: " + levelCounter; // updating the text 
         

    }
}
