using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAIV2 : MonoBehaviour
{
    
   public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    public float shootRange = 10f;
    public float projectileSpeed = 10f;
    public float fireRate = 1f;

    private Transform player;
    private float timeSinceLastShot;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= shootRange)
        {
            timeSinceLastShot += Time.deltaTime;

            if (timeSinceLastShot >= 1 / fireRate)
            {
                ShootProjectile();
                timeSinceLastShot = 0;
            }
        }
    }

    private void ShootProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        Vector3 direction = (player.position - projectileSpawnPoint.position).normalized;
        projectileRb.AddForce(direction * projectileSpeed, ForceMode.Impulse);

        Destroy(projectile, 5f);
    }

    
}

