using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 3.0f; //base rotating speed of the map
    public float speedTrue; //rotating speed of the map according to the player's position
    public static bool collisionL = false;
    public static bool collisionR = false;
    public GameObject player;
    


	void Update ()
    {
        //because the map is a circle and rotates (instead of the player being moved) I need to adjust the speed according to how low in the circle
        //the player is located. Because if a circle rotates the outer layers of the circle will make more distance than the inner layers of the circle because they have a bigger surface 
        //that needs to move in a certain amount of time
        speedTrue =  speed/(player.transform.position.y);
        speedTrue = Mathf.Clamp(speedTrue, -1.6f, 0.0f);
        if (Input.GetKey("d") && collisionR == false)
        {
            transform.Rotate(Vector3.back * -speedTrue);
        }

        if (Input.GetKey("a") && collisionL == false)
        {
            transform.Rotate(Vector3.forward * -speedTrue);
        }
		
	}
}
