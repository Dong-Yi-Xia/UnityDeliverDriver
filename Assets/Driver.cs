using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Adding SerializeField will make variable available in unity inspector
    [SerializeField] float steerSpeed = 300;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float speedUp = 50f;
    [SerializeField] float speedDown = 20f;


    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime get a constant framespeed across different computer speed
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);

        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = speedDown;    
    }


    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "SpeedUp")
        {
            Debug.Log("Speeding up");
            moveSpeed = speedUp;
        }
    }
}

