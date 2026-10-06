using UnityEngine;
using UnityEngine.InputSystem;

public class LoadMenuOnAnyKey : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            GameManager.instance.TurnOnMainMenuScreen();
        }
    }
}
