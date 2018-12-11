using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPickUp : MonoBehaviour {

    // en rigidbody som heter rbody
    public Rigidbody2D rbody;
    // en float some heter bounce ges värdet av 8
    public float bounce = 8;
    // en statisk int som heter keys
    public static int keys;
    // en int som blir värdet av nyckeln
    public int amount = 1;

    // Use this for initialization
    void Start()
    {
        // rbody är rigidbody-komponenten
        rbody = GetComponent<Rigidbody2D>();
    }

    // när något nuddar nyckeln
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om det som nuddar är en fiende...
        if (collision.tag == "Enemy")
        {
            // hoppar nyckeln med hjälp av bounce-floaten
            rbody.velocity = new Vector2(rbody.velocity.x, bounce);
        }
        // även om det som nuddar är en "invisibleWall"...
        if (collision.tag == "invisibleWall")
        {
            // hoppar också nyckeln med hjälp av bounce-floaten
            rbody.velocity = new Vector2(rbody.velocity.x, bounce);
        }
        // om det som nuddar är en "Player"...
        if (collision.tag == "Player")
        {
            // ...läggs "amount" (1) till till antalet nycklar man har...
            keys += amount;
            // ...och objektet försvinner
            Destroy(gameObject);
        }

    }
}
