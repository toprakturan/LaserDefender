using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAttentionText : MonoBehaviour
{

    [SerializeField] private float secondsToDestroy = 5f;
    void Start()
    {
        Destroy(gameObject, secondsToDestroy);
    }

    
    void Update()
    {
        
    }
}
