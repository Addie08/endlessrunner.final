using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    //Create a public array of objects to spawn, we will fill this using to Unity Editor
    public GameObject[] objectsToSpawn;

    float timeToNextSpawn;     //Tracks how long we shouldwait before spawning a new object  
    float timeSinceLastSpawn = 0.0f;      //Tracks the time since we last spammed something 


    public float minSpawnTime = 0.5f; //Minium amount of the tume between spawning objects 
    public float maxSpawnTime = 3.0f; //Maximum amount of the tume between spawning objects 

    private void Start()
    {
        //Random.Range returns a random float between to values 
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);    
    }

    void Update() 
    {
         //Add.Time.deltaTime returns the amount of tine passed since the last frame.
         //This will create a float that counts up in seconds 
         timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

        //If we've counted past the amount of time we need to wait...
        if (timeSinceLastSpawn > timeToNextSpawn)
        {
            //Use Random.Range to pick a number between 0 and the amount of items we have on our object list
            int selection = Random.Range(0, objectsToSpawn.Length);

            //Instantiate spawns a GameObject - in this case we tell it to spawn a GameObject form our objectstospawn list
            //The second parameter in the brackets tell it where to spawn, so we've entered the positionof the spawner.
            //The third parameter is for the rotation, and Quaternion.identity means no rotation
            Instantiate(objectsToSpawn[selection], transform.position, Quaternion.identity); 
              

            //After spawning, we select a new random time for the next spawn and set our timer back to zero
            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceLastSpawn = 0.0f;

         }
    }


}

