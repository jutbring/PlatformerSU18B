using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundChecker : MonoBehaviour
{
    // skapar en bool som heter isGrounded
    public int isGrounded;

    // när nägonting nuddar objektet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // blir isGrounded-variablen sann
        isGrounded ++;
    }
    // när någonting slutar nudda 
    private void OnTriggerExit2D(Collider2D collision)
    {
        // blir isGrounded-variablen falsk
        isGrounded --;
    }
}
