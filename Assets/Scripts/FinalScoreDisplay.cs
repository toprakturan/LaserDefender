using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinalScoreDisplay : MonoBehaviour
{

    Text finalScoreText;
    GameSession gameSession;

    void Start()
    {
        finalScoreText = GetComponent<Text>();
        gameSession = FindObjectOfType<GameSession>();
    }

    
    void Update()
    {
        finalScoreText.text = gameSession.getScore().ToString();
    }
}
