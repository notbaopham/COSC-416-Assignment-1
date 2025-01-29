using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] float ballSpeed = 2f;

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

        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane);
    }
}
