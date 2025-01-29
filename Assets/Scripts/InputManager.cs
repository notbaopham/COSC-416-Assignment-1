using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();

    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }
            if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }
        OnMove?.Invoke(inputVector);
    }
}

