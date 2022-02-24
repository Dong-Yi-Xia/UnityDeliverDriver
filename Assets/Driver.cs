using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Adding SerializeField will make variable available in unity inspector
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.01f;


    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        transform.Rotate(0, 0, -steerAmount);

        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(0, moveAmount, 0);
    }
}

