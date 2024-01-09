using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class EnemySpawner : NetworkBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public float spawnInterval = 5f;
    public int maxEnemyCount = 10; // Set your desired maximum enemy count

    private int currentEnemyCount = 0;
    private List<Transform> availableSpawnPoints;

    public override void OnStartServer()
    {
        availableSpawnPoints = new List<Transform>(spawnPoints);
        // Start spawning enemies on the server
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            // Check if the current enemy count is less than the maximum limit
            if (currentEnemyCount < maxEnemyCount && availableSpawnPoints.Count > 0)
            {
                // Randomly choose an index from the list of available spawn points
                int randomIndex = Random.Range(0, availableSpawnPoints.Count);
                
                // Get the chosen spawn point from the list
                Transform chosenSpawnPoint = availableSpawnPoints[randomIndex];

                // Instantiate the enemy on the server at the chosen spawn point
                GameObject enemy = Instantiate(enemyPrefab, chosenSpawnPoint.position, Quaternion.identity);

                // Remove the chosen spawn point from the list of available spawn points
                availableSpawnPoints.RemoveAt(randomIndex);

                // Spawn the enemy on all clients
                NetworkServer.Spawn(enemy);

                // Increment the current enemy count
                currentEnemyCount++;
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
