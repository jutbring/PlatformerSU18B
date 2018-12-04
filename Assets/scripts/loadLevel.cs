using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    // variabel som säger vilken scen som ska laddas
    public string sceneToLoad = "PlatformerLevel1";
    // när någonting nuddar objektet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om det som objektet nuddar är en "player" 
        if (collision.tag == "Player")
        {
            // poängen sätts till 0
            coinPickup.score = 0;
            // laddar scenen som ska laddas 
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}