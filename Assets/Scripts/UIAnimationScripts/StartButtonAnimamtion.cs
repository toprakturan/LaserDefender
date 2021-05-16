using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonAnimamtion : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] public LeanTweenType type;
    public Vector3 vectorToScale;
    [SerializeField] float speed;

    void Start()
    {
        LeanTween.scale(gameObject, vectorToScale, time).setEase(type).setLoopPingPong(500);
    }

    
    void Update()
    {
        
    }
}
