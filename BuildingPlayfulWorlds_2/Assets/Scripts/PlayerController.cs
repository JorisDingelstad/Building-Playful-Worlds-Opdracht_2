using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 550.0f;
    public static bool onTheGround;
    Rigidbody2D _rigidbody;
    public float posY;



    void Start ()
    {
        
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
        
	}
	
	
	void Update ()
    {
        posY = this.gameObject.transform.position.y;
        if (Input.GetButtonDown("Jump") && onTheGround)
        {
            _rigidbody.AddForce(Vector2.up * jumpForce);
        }

        if (Input.GetKeyDown("p"))
        {
            posY += 1;
        }

	}
}
