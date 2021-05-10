using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthAttention : MonoBehaviour
{

    Player player;
    GameSession gameSession;
    LevelDesign levelDesign;
    public int playerHealth;
    public int currentScore;
    public Text healthPopUpText;
    bool firstCheck;
    bool secondCheck;


    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        player = FindObjectOfType<Player>();
        levelDesign = FindObjectOfType<LevelDesign>();
        healthPopUpText = gameObject.GetComponent<Text>();
    }

    
    void Update()
    {
        playerHealth = player.health;
        currentScore = gameSession.score;
        firstCheck = levelDesign.checkFirstMilestoneHealth;
        secondCheck = levelDesign.checkSecondMilestoneHealth;
        textDisplayChecker();

    }

    public void textDisplayChecker()
    {
       
        
    }
}
