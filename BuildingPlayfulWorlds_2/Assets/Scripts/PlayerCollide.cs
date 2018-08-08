using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //by using these 2 If statements I don't need to make 2 seperate scripts (1 for R, 1 for L)
        //the if statements also check if the object that enters the collider does NOT have the tag "non_obstacle". 
        //this way the player can move through gameobjects with colliders that shouldn't stop movement

        if (this.gameObject.tag == "left" && collision.gameObject.tag != "non_obstacle") //for the left collider2D
        {
            Rotate.collisionL = true;
        }

        if(this.gameObject.tag == "right" && collision.gameObject.tag != "non_obstacle") //for the right collider2D
        {
            Rotate.collisionR = true;
        }

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (this.gameObject.tag == "left")
        {
            Rotate.collisionL = false;
        }

        if (this.gameObject.tag == "right")
        {
            Rotate.collisionR = false;
        }
    }

}
