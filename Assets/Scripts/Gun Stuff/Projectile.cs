using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 10f;
    public GameObject impactEffectPrefab; // Assign your impact effect prefab in the Inspector

    void Start()
    {
        // Start moving the projectile in the forward direction of its own transform
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * speed;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the projectile collides with a target
        Target target = other.GetComponent<Target>();
        if (target != null)
        {

            target.TakeDamage(damage);
        }

        // Instantiate the impact effect at the collision point
        InstantiateImpactEffect(other.transform.position, other.transform.rotation);

        // Destroy the projectile after collision
        Destroy(gameObject);
    }

    void InstantiateImpactEffect(Vector3 position, Quaternion rotation)
    {
        if (impactEffectPrefab != null)
        {
            GameObject impactGO = Instantiate(impactEffectPrefab, position, rotation);
            Destroy(impactGO, 2f); // Destroy the impact effect after 2 seconds (adjust as needed)
        }
    }
}
