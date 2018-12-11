using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossMovement : MonoBehaviour
{
    // en bool som heter up sätts till sann
    public bool up = true;
    // en statisk float som heter speed sätts till 20
    public static float speed = 20;
    // en rigidbody som heter rbody
    private Rigidbody2D rbody;
    // en statisk vector2 som heter lane
    public static Vector2 lane;
    // en statisk int som heter chooselane 
    public static int chooseLane;
    // en statisk bool some heter damaged sätts till falsk
    public static bool damaged = false;

    // Use this for initialization
    void Start()
    {
        // lane sätts till en ny vector2 
        lane = new Vector2(51, -40.5f);
        // bossen teleporteras till lane
        transform.position = lane;
        // rbodyn är rigidbody-komponenten
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // om playerCheck i bossTrigger-scriptet är sann...
        if (bossTrigger.playerCheck == true)
        {
            // ...och om "damaged" är sann...
            if (damaged == true)
            {
                // ...åker fiended med negativ speed-fart på y-axeln (neråt)
                rbody.velocity = new Vector2(rbody.velocity.x, -speed);
                // ...och den lokala skalan inverteras på y-axeln (då bossen är lutad 90 grader kommer det se ut som att den inverteras på x-axeln)
                transform.localScale = new Vector2(-6, 6);
            }
            // annars...
            else
            {
                // ...om up är sann...
                if (up == true)
                {
                    // ...åker bossen positivt på y-axeln (upåt)
                    rbody.velocity = new Vector2(rbody.velocity.x, speed);
                    // ...och spriten blir normal
                    transform.localScale = new Vector2(6, 6);
                }
                // ...om up är falsk...
                if (up == false)
                {
                    // ...åker bossen istället negativt på y-axeln (neråt)
                    rbody.velocity = new Vector2(rbody.velocity.x, -speed);
                    // ...och spriten blir skalenligt normal 
                    transform.localScale = new Vector2(-6, 6);
                }
            }
        }
    }
    // när något nuddar bossen
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om det är en "invisibleWall"...
        if (collision.tag == "invisibleWall")
        {
            // byts boolen "up" till det den inte var innan 
            up = !up;
            // om damaged är sann...
            if (damaged == true)
            {
                // ...blir chooseLane ett värde mellan 1 och 3 (4 räknas tydligen inte)
                chooseLane = Random.Range(1, 4);
                // om chooseLane blir 1...
                if (chooseLane == 1)
                {
                    // blir lane en specifik vector2
                    lane = new Vector2(44, -40.5f);
                }
                // om chooseLane istället blir 2...
                else if (chooseLane == 2)
                {
                    // blir lane en annan vecto2
                    lane = new Vector2(51, -40.5f);
                }
                // eller om chooseLane blir något annat...
                else
                {
                    // blir lane en tredje unik vector2
                    lane = new Vector2(58, -40.5f);
                }
                // bossen flyttas till lane
                transform.position = lane;
                // up blir sann
                up = true;
                // damaged blir falsk
                damaged = false;               
            }
        }
        // om det som nuddar är en "groundCheckBox"...
        if (collision.tag == "groundCheckBox")
        {
            // ...tas 1 bort från "health" i bossHealth-scriptet 
            bossHealth.health -= 1;
            // ...och damaged blir true
            damaged = true;

        }
    }
}

