using UnityEngine;

public class DeathRespawnAtCenter : Death
{
    public override void Die()
    {
        // Get Health Component
        Health healthComponent = GetComponent<Health>();

        // If it exists, set our health back to max
        if (healthComponent != null) 
        {
            healthComponent.currentHealth = healthComponent.maxHealth;        
        }

        // Move back to Center of World
        transform.position = Vector3.zero;
    }

}
