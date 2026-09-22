using UnityEngine;

public class Death : MonoBehaviour
{
    public virtual void Die()
    {
        // This what happens when this object dies
        Debug.Log("Ugh! You got me!");
    } 
}
