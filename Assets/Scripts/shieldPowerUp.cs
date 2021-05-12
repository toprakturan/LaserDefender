using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldPowerUp : MonoBehaviour
{

    
    int playerHealth;
    public bool isCollided = false;

    GameObject getShieldSprite;
    Player player;
    SpriteRenderer getRendererComponentFromPlayer;


    private void Start()
    {
        player = FindObjectOfType<Player>();
        playerHealth = player.health;
        getRendererComponentFromPlayer = player.getRendererComponent;

        getShieldSprite = player.shieldPowerUp;
        // getRendererComponent = GameObject.FindGameObjectWithTag("ShieldPowerUp");
        // getRendererComponent.GetComponent<SpriteRenderer>().enabled = false;

    }
    void Update()
    {
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isCollided = true;
        Debug.Log("collided");
        getShieldSprite.transform.parent = GameObject.Find("Player").transform;
        getShieldSprite.transform.position = player.transform.position;
        getRendererComponentFromPlayer.enabled = true;
        Destroy(gameObject);
        

    }
}
