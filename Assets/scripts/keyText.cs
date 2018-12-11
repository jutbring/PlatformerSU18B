using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyText : MonoBehaviour {

    // gör en text som heter textis
    public Text textis;
	// Use this for initialization
	void Start () {
        // textis är Text-komponenten
        textis = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        // texten i textis skriver "keys: x"
        textis.text = string.Format("keys: {0}", keyPickUp.keys);
    }
}
