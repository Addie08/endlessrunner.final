using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    //Create a reference to the Rigidbody2D so we can manipulate it 
    Rigidbody2D playerObject;

    public float speed = 10.0f;
    // Start is called before the first frame update 
    void Start()
    {
        //Find the Ridgidbody2D component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        //Create a 'float' that will be equal to the player horizontal input
        float movementValueX = Input.GetAxis("Horizonatal");
        float movementValueY = Input.GetAxis("Vertical");

        //Change the x velocity of the Rigidbody2d to be equal to the movement value 
        playerObject.velocity = new Vector2(movementValueX * speed, movementValueX * speed);
    }
}
 