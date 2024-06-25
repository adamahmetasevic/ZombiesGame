using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab
    public int initialEnemyCount = 5; // Number of enemies to spawn initially
    public int additionalEnemyCount = 2; // Number of enemies to spawn periodically
    public float spawnRadius = 50.0f; // Radius around the spawn point to spawn enemies
    public float spawnInterval = 5.0f; // Time interval between additional spawns

    void Start()
    {
        SpawnInitialEnemies();
        StartCoroutine(SpawnAdditionalEnemies());
    }

    void SpawnInitialEnemies()
    {
        for (int i = 0; i < initialEnemyCount; i++)
        {
            Vector3 randomPosition = GetRandomPosition();
            Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
        }
    }

    IEnumerator SpawnAdditionalEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            for (int i = 0; i < additionalEnemyCount; i++)
            {
                Vector3 randomPosition = GetRandomPosition();
                Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            }
        }
    }

    Vector3 GetRandomPosition()
    {
        float x = Random.Range(-spawnRadius, spawnRadius);
        float z = Random.Range(-spawnRadius, spawnRadius);
        float y = 0; // Adjust y to be above ground level or use a terrain height function
        return new Vector3(x, y, z);
    }
}
