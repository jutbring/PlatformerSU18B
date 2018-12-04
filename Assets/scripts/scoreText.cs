using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreText : MonoBehaviour
{
    // skaffar en text-variabel 
    public Text textis;

    // Use this for initialization
    void Start()
    {
        // sätter tex-variablen till att referera text-komponenten
        textis = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // sätter text-komponenten i text-variablen till antalen poäng man har i den statiska "coin" variablen i coinPickup 
        textis.text = string.Format("score: {0}", coinPickup.score);
       
    }
}
