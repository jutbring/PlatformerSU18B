using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockScript : MonoBehaviour {

    // när något nuddar låset
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // om det som nuddar är en player...
        if (collision.gameObject.tag == "Player")
        {
            // om spelaren har en eller flera nycklar...
            if (keyPickUp.keys >= 1)
            {
                // ...försvinner låset...
                Destroy(gameObject);
                // ...och en nyckel tas bort
                keyPickUp.keys--;
            }
        }
    }
}
