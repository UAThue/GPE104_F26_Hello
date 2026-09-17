using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerPlayer : Controller
{
    public Key moveForward;
    public Key moveBackward;
    public Key rotateRight;
    public Key rotateLeft;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[moveForward].isPressed)
        {
            // Move Forward
            pawn.Move(pawn.transform.up);
        }
        if (Keyboard.current[moveBackward].isPressed)
        {
            // Move Backward
        }
        if (Keyboard.current[rotateRight].isPressed)
        {
            // rotate right
        }
        if (Keyboard.current[rotateLeft].isPressed)
        {
            pawn.Rotate(1);
        }
    }
}
