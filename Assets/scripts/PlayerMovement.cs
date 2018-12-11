using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    
    public static bool left;
    // sätter farten
    public float movementSpeed = 8f;
    // sätter hoppkraften
    public float jumpSpeed = 8f;

    // skapar en groundChecker 
    public groundChecker groundCheck;
    // skapar en rigidbody
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        // om bossTriggern har känt av spelaren...
        if (bossTrigger.playerCheck == true)
        {
            // ...byts spawnpointen
            transform.position = new Vector2(37, -19 );
        }
        // sätter rigidbodyn till att referera till rigidbody-komponenten
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // ridgidbodyns horisontala hastighet sätts till det aktuella horisontala värdet ( D=1, A=-1. Samma med piltangenterna eller joystick) 
        // den vertikala hastigheten sätts till samma som det var innan 
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, rbody.velocity.y);
        // om man trycker på hopp (space eller Y) 
        if (Input.GetButtonDown("Jump"))
        {
            // om isGrounded-variablen is groundCheck-criptet är sann (att den nuddar marken)
            if (groundCheck.isGrounded >0)
            {
                // ridgidbodyns vertikala hastighet sätts till hoppkraften
                // den horisontala hastigheten såtts till samm som den var innan
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
            }
        }
        // om spelaren rör sig åt mindre än 0 åt x (vänster)...
        if (rbody.velocity.x < 0)
        {
            // ...pekar spelaren åt vänster
            left = true;
        }
        // om spelaren rör sig åt mer än 0 åt x (höger)...
        if (rbody.velocity.x > 0)
        {
            // ...pekar spelaren åt höger
            left = false;
        }
        // om spelaren pekar mot vänster...
        if (left == true)
        {
            // ...inverteras spriten åt vänster
            transform.localScale = new Vector3(-.8f, .8f, .8f);
        } 
        // annars...
        else
        {
            // ...blir spriten normal
            transform.localScale = new Vector3(.8f, .8f, .8f);
        }

    }
    // när något nuddar spelaren
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om det som nuddar är spelaren...
        if (collision.tag == "Enemy")
        {
            // ...hoppar spelaren
            rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
        }
    }
}
