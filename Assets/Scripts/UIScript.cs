﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
    
    
    public TextMeshProUGUI healthText;
    public int currentHealth;
    Player player;
    


    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
       
    }

    
    void Update()
    {
        
        currentHealth = player.health;
        
        if(currentHealth < 0)
        {
            healthText.text = "0";
        }
        else
        {
            healthText.text = currentHealth.ToString();
        }

    }

    public void ShowHealthAttention()
    {
        
    }
}
