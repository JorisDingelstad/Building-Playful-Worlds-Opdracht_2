using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{


    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController.onTheGround = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayerController.onTheGround = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerController.onTheGround = false;
    }
}
