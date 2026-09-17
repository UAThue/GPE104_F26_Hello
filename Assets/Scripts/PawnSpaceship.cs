using UnityEngine;

public class PawnSpaceship : Pawn
{
    public float moveSpeed = 3;
    public float turnSpeed = 180;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Move (Vector3 moveVector)
    {
        // Change my position by adding the moveVector to my position and storing it back in my position
        transform.position += moveVector * moveSpeed * Time.deltaTime;
    }

    public override void Rotate (float angle)
    {
        transform.Rotate (0,0,angle * turnSpeed * Time.deltaTime);
    }
}
