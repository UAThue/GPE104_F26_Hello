using UnityEngine;

public class DeathExplode : Death
{
    public float explosionForce;
    public float explosionDistance;
    public float explosionDamage;

    public override void Die()
    {
        // Do what all death components do
        base.Die();

        // TODO: Spawn an explosion particle effect
        // TODO: Grab all objects within a given distance and push them away with a given force
        // TODO: Damage all objects hit by the explosion

        // Remove this game object from the game
        Destroy(this.gameObject);
    }
}
