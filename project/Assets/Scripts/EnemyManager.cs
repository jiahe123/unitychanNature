using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public GameObject enemy;                 
    public float spawnTime = 15f;             
    public Transform[] spawnPoints;          


    void Start()
    {
        
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        // If the player has no health left...
       /* if (playerHealth.currentHealth <= 0f)
        {
            // ... exit the function.
            return;
        }*/

         
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

         
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
