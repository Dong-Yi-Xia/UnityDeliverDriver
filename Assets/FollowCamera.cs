using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Add a field in unity, a reference variable
    [SerializeField] GameObject thingToFollow;


    // This things position (camera) should be the same as the car's position
    // Using LateUpdate, smoother camera follow update because of the order of rendering the script/object
    void LateUpdate()
    {
        // call the new reference object, get access to object property by looking at the inspector 
        // use the Vector to change the x,y,z 
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
