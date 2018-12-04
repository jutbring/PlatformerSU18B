using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinPickup : MonoBehaviour
{    
    // en int som är samma i all scripts, namnges "score"
    public static int score; 
    // sätter värdet av ett mynt
    public int amount = 1;
    // sätter hastigheten för hur snabbt myntet ska snurra
    private float spinSpeed = 360;
    // Update is called once per frame
    private void Update()
    {
        // roterar objektet (myntet) i 0, deltatid * hastigheten, 0. Alltså snurrar myntet på y-axeln
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
    // när något rör myntet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om det som rör är taggad "player" 
        if (collision.tag == "Player")
        {
            // lägger till + 1 på den statiska variablen "score" i "coinPickup" scriptet 
            coinPickup.score += amount;
            // ta bort myntet
            Destroy (gameObject);
        }
    }
}
