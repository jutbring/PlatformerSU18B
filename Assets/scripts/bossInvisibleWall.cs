using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossInvisibleWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // om health i bossHealth-scriptet är mindre än ett
		if (bossHealth.health < 1)
        {
            // förstörs objektet
            Destroy(gameObject);
        }
	}
}
