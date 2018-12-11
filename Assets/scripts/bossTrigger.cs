using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossTrigger : MonoBehaviour
{
    // en bool som heter playerCheck sätts till sann
    public static bool playerCheck = false;

    // när något nuddar objektet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om det som nuddar är en "Player"...
        if (collision.tag == "Player")
        {
            // ...blir playerCheck sann
            playerCheck = true;
          
        }
    }
}
