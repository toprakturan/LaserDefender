using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelDesign : MonoBehaviour
{
    //Define variables
    public int currentScore;
    public int addHealth1 =300;
    public int addHealth2 = 400;
    public string healthTextString;
    [SerializeField] [Range(1, 50)] float gameSpeed = 1;
    [SerializeField] public GameObject HealthAttentionText;

    //Milestone Checks
    public bool checkFirstMilestoneHealth = true;
    public bool checkSecondMilestoneHealth = true;
    public bool checkThirdMilestoneHealth = true;
    public bool checkSixthMilestoneHealth = true;
    

    //Get datas from other Scripts
    GameSession gameSession;
    Player player;
    public int currentPlayerHealth;
    

    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        player = FindObjectOfType<Player>();
       
        
        
    }

    
    void Update()
    {
        currentScore = gameSession.score;
        currentPlayerHealth = player.health;
        Time.timeScale = gameSpeed;
        CheckPointsForSpeed();
    }

    public void CheckPointsForSpeed()
    {
        //First Milestone 
       if(currentScore >= 1000 && checkFirstMilestoneHealth == true)
        {
            //Debug.Log(currentScore);
            gameSpeed = 1.2f;
            player.health += addHealth1;
            checkFirstMilestoneHealth = false;
            healthTextString = "+" + addHealth1 + " Health";
            showHealthAttention(healthTextString.ToString());


        }

       if(currentScore >= 2000 )
        {
            gameSpeed = 1.3f;
        }
       //Second Milestone
        if(currentScore >= 3000 && checkSecondMilestoneHealth == true)
        {
            gameSpeed = 1.4f;
            player.health += addHealth1;
            checkSecondMilestoneHealth = false;
            healthTextString = "+" + addHealth1 + " Health";
            showHealthAttention(healthTextString.ToString());


        }
        if(currentScore >= 4000)
        {
            gameSpeed = 1.5f;
        }
        //Third Milestone 
        if (currentScore >= 5000 && checkThirdMilestoneHealth == true)
        {
            gameSpeed = 1.6f;
            player.health += addHealth2;
            checkThirdMilestoneHealth = false;
            healthTextString = "+" + addHealth2 + " Health";
            showHealthAttention(healthTextString.ToString());
        }

        if (currentScore >= 6000)
        {
            gameSpeed = 1.7f;
        }
        //Fourth Milestone 
        if (currentScore >= 6000 && checkSixthMilestoneHealth == true)
        {
            gameSpeed = 1.7f;
            checkSixthMilestoneHealth = false;
        }
        //Sixth Milestone 
        if (currentScore >= 8000 && checkSixthMilestoneHealth == true)
        {
            gameSpeed = 1.9f;
            player.health += addHealth2;
            checkSixthMilestoneHealth = false;
            healthTextString = "+" + addHealth2 + " Health";
            showHealthAttention(healthTextString.ToString());
        }

    }

    public void showHealthAttention(string text)
    {
        GameObject prefab = Instantiate(HealthAttentionText, new Vector3(0,0,12f), Quaternion.identity);
        prefab.GetComponentInChildren<TextMesh>().text = text;
    }

    
    
   
}
