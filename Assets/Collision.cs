using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("I crushed");
    }

    // using the "is trigger" in Collider 2D field 
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("I went through a wall");
    }
}
