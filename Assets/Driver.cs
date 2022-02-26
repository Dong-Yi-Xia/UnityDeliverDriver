using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Adding SerializeField will make variable available in unity inspector
    [SerializeField] float steerSpeed = 300;
    [SerializeField] float moveSpeed = 20.5f;


    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime get a constant framespeed across different computer speed
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);

        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
    }
}

