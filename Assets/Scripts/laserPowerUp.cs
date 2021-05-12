using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserPowerUp : MonoBehaviour
{
    Player player;
    int playerHealth;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        playerHealth = player.health;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("carpisma1");
        Destroy(gameObject);
    }
}
