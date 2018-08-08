using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is used to open doors in the game when the player collides with this gameobjects collider

public class DoorSwitch : MonoBehaviour
{

    public GameObject door;
    public GameObject destination;
    public GameObject originalPosition;
    public bool switchHit;
    

    // Update is called once per frame
    private void Awake()
    {
        switchHit = false;
    }

    void Update ()
    {

	    if(switchHit)
        {
        //    door.transform.position = Vector3.MoveTowards(door.transform.position, destination.position, 10.0f * Time.deltaTime); 
        }

        if(!switchHit)
        {
       //     door.transform.position = Vector3.MoveTowards(door.transform.position, originalPosition.position, 10.0f * Time.deltaTime);
        }

        if (Input.GetKeyDown("e"))
        {
            if (switchHit)
            {
                switchHit = false;
            }

            else
            {
                switchHit = true;
            }
        }

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (switchHit && collision.gameObject.tag == "groundcheck")
        {
            switchHit = false;
        }

        else if (!switchHit && collision.gameObject.tag == "groundcheck")
        {
            switchHit = true;
        }
    }

}
