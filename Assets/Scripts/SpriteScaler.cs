using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteScaler : MonoBehaviour
{
    public Key growKey = Key.P;
    public Key shrinkKey = Key.L;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the "GrowKey" key is pressed.
        // If so...
        if (Keyboard.current[growKey].wasPressedThisFrame)
        {
            // Increase the scale of this sprite
            transform.localScale +=  new Vector3(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1, 5));
        }


        // Check if the "ShrinkKey" key is pressed.
        // If so...
        if (Keyboard.current[shrinkKey].wasPressedThisFrame)
        {
            // Decease the scale of this sprite
            transform.localScale -= new Vector3(1,1,1);
        }



    }
}
