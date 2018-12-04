using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // får och stänger av spriterenderern för att få objektet osynligt
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
