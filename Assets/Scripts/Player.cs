using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    // configuration parameters

    [Header("Player")]
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float padding = 1f;

    [SerializeField] public int health;

    [Header("Projectile")]
    [SerializeField] public GameObject laserPrefab;
    [SerializeField] public GameObject laserPowerUpPrefab;
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] float projectileFiringPeriod = 0.1f;

    //For Audio 
    [SerializeField] AudioClip playerShooting;
    [SerializeField] [Range(0, 1)] float playerShootingVolume = 0.75f;
    [SerializeField] AudioClip playerDeath;
    [SerializeField] [Range(0, 1)] float playerDeathVolume = 0.75f;

   


    shieldPowerUp ShieldPowerUp;
    public bool laserIsCollided; 
    laserPowerUp LaserPowerUp;
    public List<GameObject> laserPowerUpCollided;
    
    

    Coroutine firingCoroutine;

    float xMin;
    float xMax;
    float yMin;
    float yMax;

    
    void Start()
    {
        SetUpMoveBoundaries();
        
        
        
    }

   
    void Update()
    {
        Move();
        Fire();
        

    }

   
    


    private void OnTriggerEnter2D(Collider2D other)
    {
        DamageDealer damageDealer = other.gameObject.GetComponent<DamageDealer>();
        if (!damageDealer) { return; }
        ProcessHit(damageDealer);
    }
    private void ProcessHit(DamageDealer damageDealer)
    {
        health -= damageDealer.GetDamage();
        damageDealer.Hit();
        if (health <= 0)
        {
            
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(playerDeath, Camera.main.transform.position, playerDeathVolume);
            FindObjectOfType<Level>().LoadGameOver();

        }
    }
    private void Fire()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            firingCoroutine = StartCoroutine(FireContinuously());
            
        }
        if (Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(firingCoroutine);
        }
    }

    
    IEnumerator FireContinuously()
    {
            while (true)
            {
                GameObject laser = Instantiate(
                        laserPrefab,
                        transform.position,
                        Quaternion.identity) as GameObject;
                laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
                AudioSource.PlayClipAtPoint(playerShooting, Camera.main.transform.position, playerShootingVolume);
                yield return new WaitForSeconds(projectileFiringPeriod);
            }
        
    }
    


    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        var newXPos = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);
        var newYPos = Mathf.Clamp(transform.position.y + deltaY, yMin, yMax);
        transform.position = new Vector2(newXPos, newYPos);
    }

    private void SetUpMoveBoundaries()
    {
        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }
}
