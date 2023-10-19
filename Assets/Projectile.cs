using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision) 
    {
        // Check if the projectile hit an object with a specific tag (e.g., "Enemy")
        if (collision.CompareTag("Player"))
        {
            // Apply damage to the enemy, if it has a script with a method to handle it
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Destroy(collision.gameObject);
        }

    }
}
