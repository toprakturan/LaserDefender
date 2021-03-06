using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveConfig : ScriptableObject
{

    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] public int addScore;

    //Inıtalize score to change timeBetweenSpawns when player reach milestones.
    

    public GameObject GetEnemyPrefab() { return enemyPrefab; }

    public List<Transform> GetWaypoints()
    {
        //we create new list(only transform type) which is waveWaypoints 
        var waveWaypoints = new List<Transform>();
        //after that we added all wavepoints in pathPrefab gameObject to waveWaypoints list)
        foreach (Transform child in pathPrefab.transform)
        {
            //thus we doesn't need to add wavepoints manually in waveConfig
            waveWaypoints.Add(child);
        }
        return waveWaypoints;
    }

    public float GetTimeBetweenSpawns() 
    {
        
        return timeBetweenSpawns; 
    }

    public float GetSpawnRandomFactor() { return spawnRandomFactor; }

    public int GetNumberOfEnemies() { return numberOfEnemies; }

    public float GetMoveSpeed() { return moveSpeed; }

}