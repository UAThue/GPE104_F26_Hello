using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame.
    void Update()
    {
        
    }

    public float GetHealthPercent()
    {
        return currentHealth / maxHealth;
    }

    public void TakeDamage ( float damage )
    {
        
        // subtract damage from my current health
        currentHealth = currentHealth - damage;

        // if my current health is less than zero
        if (currentHealth <= 0)
        {
            // Set health to zero, so we don't get negative health bars in our UI
            currentHealth = 0; 

            // tell this pawn to die
            Die();
        }
    }

    public void Heal ( float healAmount )
    {
        // Add to our health
        currentHealth += healAmount;

        // If health > max, then set health to max
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public void Die()
    {
        Death deathComponent;
        deathComponent = this.gameObject.GetComponent<Death>();
        if (deathComponent != null)
        {
            deathComponent.Die();
        }            
    }
}
