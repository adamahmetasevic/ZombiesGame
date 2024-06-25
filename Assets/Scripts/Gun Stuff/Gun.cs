using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject projectilePrefab; // Assign your projectile prefab in the Inspector
    public GameObject muzzleFlash; // Assign your muzzle flash GameObject in the Inspector

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("I am shooting");
            Shoot();
        }
    }

    void Shoot()
    {
        StartCoroutine(ShowMuzzleFlash());

        // Instantiate the projectile at the gun's position and rotation
        GameObject projectileGO = Instantiate(projectilePrefab, muzzleFlash.transform.position, transform.rotation);

        // Get the Projectile component from the instantiated projectile (if it has one)
        Projectile projectile = projectileGO.GetComponent<Projectile>();

        // Check if the Projectile component exists, and if so, set its damage value
        if (projectile != null)
        {
            projectile.damage = 10f; // Set the damage value as needed
        }
    }

    IEnumerator ShowMuzzleFlash()
    {
        muzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        muzzleFlash.SetActive(false);
    }
}
