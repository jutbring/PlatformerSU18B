using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHealth : MonoBehaviour
{
    // en spriteRenderer som heter rend
    public SpriteRenderer rend;
    // en statisk int som heter health sätts till 10
    public static int health = 10;
    // en ny färg some heter color1 
    public Color color1 = new Color(0.6f, 0.5f, 0.5f);
    // en ny färg some heter color2 
    public Color color2 = new Color(0.6f, 0.25f, 0.25f);
    // en ny färg some heter color3
    public Color color3 = new Color(1, 0.1f, 0.1f);
    // en sprite som heter dead
    public Sprite dead;

    // Use this for initialization
    void Start()
    {
        // rend sätts till att referera till spriteRenderer-komponenten
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // om health är mer än 7...
        if (health > 7)
        {
            // ...sätts bossens fart till 20
            bossMovement.speed = 20;
            // ...sätts färgen till color1
            rend.color = color1;

        }
        // om health är mer än 3...
        else if (health > 3)
        {
            // ...sätts bossens fart till 30
            bossMovement.speed = 30;
            // ...sätts färgen till color2
            rend.color = color2;
        }
        // om health är mer än 1...
        else if (health > 1)
        {
            // ...sätts farten till 50
            bossMovement.speed = 50;
            // ...sätts färgen till color3
            rend.color = color3;
        }
        // om health är 0...
        else if (health > 0)
        {
            // ...sätts farten till 10
            bossMovement.speed = 10;
            // ...sätts färgen till color1 igen
            rend.color = color1;
        }
        // annars...
        else
        {
            // ...blir speed från bossMovement-scriptet 0
            bossMovement.speed = 0;
            // ...byts spriten till dead-spriten
            rend.sprite = dead;
            // ...bossen flyttas till en bestämd plats
            transform.position = new Vector2(51, -21.5f);
        }
      
    }

}

