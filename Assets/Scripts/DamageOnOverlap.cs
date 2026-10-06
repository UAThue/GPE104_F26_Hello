using UnityEngine;

public class DamageOnOverlap : MonoBehaviour
{
    public float damageDone;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D ( Collider2D otherCollider ) 
    {
        Health otherHealth;

        // Get the health component from the other object
        otherHealth = otherCollider.gameObject.GetComponent<Health>();

        // Does that health component exist?? Or maybe this was an object without health!
        if (otherHealth != null)
        {
            // Tell that health component to take damage
            otherHealth.TakeDamage( damageDone );
        }
    }
}
