using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldPowerUp : MonoBehaviour
{

    
    int playerHealth;
    public bool isCollided;
    DamageDealer damageDealer;
    [SerializeField] public GameObject projectileReference;

    [SerializeField] public SpriteRenderer shieldSprite;
    public SpriteRenderer cloneShiledSprite;
    Player player;
    


    private void Start()
    {
        player = FindObjectOfType<Player>();
        playerHealth = player.health;
        isCollided = false;
        damageDealer = FindObjectOfType<DamageDealer>();
        


    }
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log("collided");
        
        StartCoroutine(shieldSpriteController());
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

    }

   IEnumerator shieldSpriteController() 
    {
        isCollided = true;

        if (isCollided == true)
        {
            cloneShiledSprite = Instantiate(shieldSprite, player.transform.position, Quaternion.identity);
            cloneShiledSprite.transform.parent = player.transform;
            cloneShiledSprite.transform.position = player.transform.position;
            projectileReference.GetComponent<DamageDealer>().damage = 1;
            yield return new WaitForSeconds(5f);
            projectileReference.GetComponent<DamageDealer>().damage = 100;
            isCollided = false;
            Debug.Log(isCollided);
            Destroy(cloneShiledSprite);
            
            

        }
        else 
        {
            
            
        }


    }

    public void deneme()
    {
        if (isCollided == true)
        {
            SpriteRenderer cloneShiledSprite = Instantiate(shieldSprite, player.transform.position, Quaternion.identity);
            cloneShiledSprite.transform.parent = player.transform;
            cloneShiledSprite.transform.position = player.transform.position;
            
        }
    }



}
