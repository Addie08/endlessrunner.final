using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Much like the Start() and Update() methods, OnTriggerEnter2D is a special Unity method that is called 
    //by Unity automatically at a specific point - in this case, whne something enters the Tigger attached 
    //to this GameObject 
    private void OnTriggerEnter(Collider2D collision)
    {  
        //If the GameObject that has collided with our trigeer is tagged with CleanUp...
        if (collision.gameObject.tag == "CleanUp")
        {
           //Then we use this method to destroy it
           Destroy(collision.gameObject);
        }        
    }
}
