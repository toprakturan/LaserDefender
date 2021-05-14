using System.Collections;
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
        healthText.text = currentHealth.ToString();

    }

    public void ShowHealthAttention()
    {
        
    }
}
