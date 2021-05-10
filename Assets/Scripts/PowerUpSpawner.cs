using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{

    [SerializeField] List<GameObject> powerUps;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;


    
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        
    }

   
    public void SpawnObject()
    {
        Instantiate(powerUps[Random.Range(0,5)], , transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
