using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinalScoreDisplay : MonoBehaviour
{

    GameSession gameSession;
    int gameSessionScore;
    [SerializeField] Text finalScoreDisplay;

    void Start()
    {
        
        
    }

    
    void Update()
    {
        gameSession = FindObjectOfType<GameSession>();
        gameSessionScore = gameSession.score;
        finalScoreDisplay.text = gameSessionScore.ToString();
       
        
    }
}
