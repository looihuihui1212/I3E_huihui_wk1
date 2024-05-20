using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
    
{
    bool opened = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && !opened)
            //open the door
            OpenDoor();
    }

    void OpenDoor()
    {
        // store the objects rotation
        Vector3 newRotation = transform.eulerAngles;

        //modify the new variable
        newRotation.y += 90f;

        // re-assign the value to the object rotation
        transform.eulerAngles = newRotation;

        opened = true;
    }

    void CloseDoor()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.y -= 90f; 
        transform.eulerAngles = newRotation;
        opened = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
