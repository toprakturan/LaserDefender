using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHeaderAnimation : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] public LeanTweenType type;
    public Transform transfom;
    [SerializeField] float speed;
    void Start()
    {
        LeanTween.move(gameObject, transfom, speed).setEase(type).setLoopPingPong(500);
    }

    
    void Update()
    {
        
    }
}
