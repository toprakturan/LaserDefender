using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserPowerUp : MonoBehaviour
{
    [SerializeField] GameObject laserPowerUpSprite;
    Player player;
    int playerHealth;
    public int colliderCount;

    public bool isCollided;

    private void Start()
    {
        isCollided = false;
        player = FindObjectOfType<Player>();
        playerHealth = player.health;
        colliderCount = 0;

    }

    private void Update()
    {
        
        Debug.Log(isCollided);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("carpisma1");
        colliderCount++;
        isCollided = true;
        powerUpController();
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        

    }


    IEnumerator powerUpController()
    {
        isCollided = true;
        if(isCollided == true)
        {
            yield return new WaitForSeconds(5f);
            isCollided = false;
            colliderCount = 0;
            
        }
        else
        {
            isCollided = false;
        }


    }



    
}
