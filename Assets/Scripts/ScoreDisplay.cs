using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{

    Text scoreText;
    GameSession GameSession;
    

    void Start()
    {
        scoreText = GetComponent<Text>();
        GameSession = FindObjectOfType<GameSession>();
        
    }

    
    void Update()
    {
        scoreText.text = GameSession.getScore().ToString();
    }
}
