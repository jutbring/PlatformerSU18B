using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    // sätter fiendens fart 
    float speed = 3f;
    // bool som indikerar vilket håll fienden rör sig åt
    public bool left = true;
    // skapar en rigidbody som heter rbody
    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        // sätter så att rbody refererar till rigidbody-komponenten
        rbody = GetComponent<Rigidbody2D>();
    }
    // void som händer ett antal gånger per sekund, snarare än varje frame
    public void FixedUpdate()
    {
        // om fienden rör sig åt vänster 
        if (left == true)
        {
            // rigidbodyns horisontala velocitet sätts tillnegativt höger * fiendens fart 
            rbody.velocity = -(Vector2)transform.right * speed;
            // sätter fiendens scale till 1, 1, 1
            transform.localScale = new Vector3(1, 1, 1);
        }
        // om fienden inte rör sig åt vänster
        else
        {
            // rigidbodyns horisontala velocitet sätts till höger * fiendens fart 
            rbody.velocity = (Vector2)transform.right * speed;
            // inverterar fiendens sprite horisontalt 
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
    // om någonting nuddar objektet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om det som nuddar är en "invisibleWall"
        if (collision.tag == "invisibleWall")
        {
            // left-variablen blir det den inte blir innan
            left = !left;
        }
        if (collision.tag == "weapon")
        {
            Destroy(gameObject);
        }
    }
   
}
