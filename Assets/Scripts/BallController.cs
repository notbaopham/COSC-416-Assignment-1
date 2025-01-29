using UnityEngine;
using System;
using System.Collections.Generic;


public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] float ballSpeed = 2f;

    public List <string> currentCollisions = new List <string> ();
	
	void OnCollisionEnter (Collision col) {

		// Add the GameObject collided with to the list.
		currentCollisions.Add (col.gameObject.name);
        Debug.Log("Sphere is colliding the plane");
	}

	void OnCollisionExit (Collision col) {
		// Remove the GameObject collided with from the list.
		currentCollisions.Remove (col.gameObject.name);
        Debug.Log("Sphere is off the plane");
	}

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; // Initiaize our input vector
        Vector3 inputJumpVector = Vector3.zero;
        
        if (Input.GetKey(KeyCode.W)) // W key presed
        {
            inputVector += Vector2.up;
        }

        
        if (Input.GetKey(KeyCode.A)) // A key pressed
        {
            inputVector += Vector2.left;
        }

        
        if (Input.GetKey(KeyCode.S)) // S key pressed
        {
            inputVector += Vector2.down;
        }

        
        if (Input.GetKey(KeyCode.D)) // D key pressed
        {
            inputVector += Vector2.right;
        }

        if (Input.GetKey(KeyCode.Space) & currentCollisions.Contains("Plane"))
        {
            inputJumpVector += 10*Vector3.up;
        }

        Vector3 inputXYZPlane = new Vector3(inputVector.x, inputJumpVector.y, inputVector.y);
        sphereRigidbody.AddForce(inputXYZPlane);
    }
}
