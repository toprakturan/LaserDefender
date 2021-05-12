using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Power Up Config")]
public class PowerUpConfig : ScriptableObject
{

    [SerializeField] GameObject spawnLocationObject;

    public List<Transform> GetLocationPoints()
    {
        var powerUpPoints = new List<Transform>();

        foreach(Transform child in spawnLocationObject.transform)
        {
            powerUpPoints.Add(child);
        }

        return powerUpPoints;
    }
}
