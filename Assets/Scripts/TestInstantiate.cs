using UnityEngine;
using UnityEngine.InputSystem;

public class TestInstantiate : MonoBehaviour
{
    Key theKey = Key.Space;
    public GameObject myPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    public void HandleInput()
    {
        if (Keyboard.current[theKey].wasPressedThisFrame)
        {
            SpawnStarship();
        }
    }

    public void SpawnStarship()
    {
        GameObject newShip = Instantiate(myPrefab, Vector3.zero, Quaternion.identity) as GameObject;
    }

}
