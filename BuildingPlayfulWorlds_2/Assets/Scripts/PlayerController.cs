using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5.0f;
    public static bool onTheGround;
    public bool debugGrounded;
    Rigidbody2D _rigidbody;

	
	void Start ()
    {
        
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
        
	}
	
	
	void Update ()
    {
        debugGrounded = onTheGround;
        if (Input.GetButtonDown("Jump") && onTheGround)
        {
            _rigidbody.AddForce(Vector2.up * jumpForce);
        }
        
	}
}
