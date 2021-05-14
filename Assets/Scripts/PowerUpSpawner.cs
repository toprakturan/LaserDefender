using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField] public List<GameObject> powerUpImages;
    [SerializeField] GameObject powerUpLocationObject;
    [SerializeField] public float spawnTime;
    [SerializeField] public float spawnDelay;
    public List<Transform> powerUpLocations;
    public bool stopSpawn = false;
    public float destroyTime;
    


    private void Awake()
    {
         // var powerUpLocations = new List<Transform>();
        foreach (Transform child in powerUpLocationObject.transform)
        {
            powerUpLocations.Add(child);
        }
    }

    void Start()
    {
        InvokeRepeating("powerUpSpawner", spawnTime, spawnDelay);
    }

    void Update()
    {
        
    }

    private void powerUpSpawner()
    {
       var powerUp =  Instantiate(powerUpImages[Random.Range(0, 2)], powerUpLocations[Random.Range(0, 5)].transform.position, 
            powerUpLocations[Random.Range(0, 5)].transform.rotation);
        if(stopSpawn == true)
        {
            CancelInvoke("powerUpSpawner");
        }
        Destroy(powerUp, destroyTime);
    }

}
