using UnityEngine;

public class ControllerAISeeker : ControllerAI
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            // Tell our pawn to move towards our target

            // Get our target position
            Vector3 end = target.transform.position;
            // Get our own position
            Vector3 start = pawn.transform.position;

            // Find the vector from start to end
            Vector3 vectorFromStartToEnd = end - start;

            // Make that vector a distance of 1 (magnitude of 1)
            vectorFromStartToEnd.Normalize();

            // Tell the pawn to move in that direction
            pawn.Move(vectorFromStartToEnd);
        }  
        else
        {
            // We have no target, so do nothing!
        }
    }
}
