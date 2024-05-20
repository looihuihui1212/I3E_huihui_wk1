using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    int myScore = 5;
    bool collected = false;
    float expirationTime = 5.5f;
    int healthLeft = 10;
    string spawnArea = "Tutorial";

    private void OnCollisionEnter(Collision collision)
    {
        //check if what is collided is the player
        if(collision.gameObject.tag == "Player")
        {
            //tell player to increase its score
            //collision.gameobject refers to whatever
            //object touches the collectibe
            collision.gameObject.GetComponent<Player>().IncreaseScore(myScore);

            //print message with gameobject name
            Debug.Log("something collided with " + gameObject.name);

            //destory my gameobject
            Destroy(gameObject);
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("something stopped colliding with me :D");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("something is still colliding with me!!");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("something is entered my zone!");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("something left my zone!");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("something is still in my zone!!");
    }



    void Collect()
    {
        if (collected)
        {
            // Dont get collected again
        }
        else
        {
            //collected and increase score, playerScore += Score
        }
    }
    void Expire()
    { 
    
    }

    void Animate()
    { 
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}