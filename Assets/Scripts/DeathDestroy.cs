using UnityEngine;

public class DeathDestroy : Death
{
    public override void Die()
    {
        // Do what ALL Death components do
        base.Die();

        // Destroy this object
        Destroy(this.gameObject);
    }

}
