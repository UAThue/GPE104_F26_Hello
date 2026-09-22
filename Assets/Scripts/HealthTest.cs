using UnityEngine;
using UnityEngine.InputSystem;

public class HealthTest : MonoBehaviour
{
    public Health healthToTest;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.Space].wasPressedThisFrame)
        {
            healthToTest.TakeDamage(10);
        }

        if (Keyboard.current[Key.P].wasPressedThisFrame)
        {
            healthToTest.Heal(20);
        }
    }
}
