using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Importing the textmesh pro

public class EndExp : MonoBehaviour
{
    public TextMeshProUGUI endExp; //The text that will show up

    // Start is called before the first frame update
    void Start()
    {
        endExp = GetComponent<TextMeshProUGUI> (); //making a reference to the end exp gameObject

    }

    // Update is called once per frame
    void Update()
    {
        endExp.text = "Exp: " + ExpCounter.expCounter + "  earned"; // updating the text 
        
    }
}
