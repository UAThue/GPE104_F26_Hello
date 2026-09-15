using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteScaler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check if the P key is pressed.
        // If so...
        if (Keyboard.current[Key.P].wasPressedThisFrame)
        {
            // Increase the scale of this sprite
            Transform tf;
            tf = GetComponent<Transform>();
            tf.localScale = new Vector3(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1, 5));
        }


        // Check if the L key is pressed.
        // If so...
        
        // Decease the scale of this sprite

        
    }
}
