using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // Default bool is false
    bool hasPackage;

    [SerializeField] float destoryDelay = 0.5f;

    [SerializeField] Color32 hasPackageColor = new Color32 (250, 77, 77, 250);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);

    // Type SpriteRender 
    SpriteRenderer spriteRenderer; 

    void Start() 
    {
        // Use the GetComponent to get component of a gameObject 
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("I crushed");
    }

    // using the "is trigger" in Collider 2D field 
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("I picked up a package");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destoryDelay);
        } 
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package been deliveried");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
