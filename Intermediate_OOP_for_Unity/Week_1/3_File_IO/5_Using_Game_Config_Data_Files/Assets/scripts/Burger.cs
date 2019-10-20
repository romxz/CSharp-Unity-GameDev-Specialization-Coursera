using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A burger
/// </summary>
public class Burger : MonoBehaviour
{
	// projectile
	public GameObject prefabProjectile;

	// explosion
	public GameObject prefabExplosion;

	// burger stats and status
	int health = 100;
	bool burgerDead = false;
	GUIText healthText;
    const string HealthPrefix = "Health: ";
        
    // shooting support
	bool canShoot = true;
	float elapsedCooldownTime = 0;
    const float FrenchFriesProjectileOffset = 0.1f;

	// used for clamping
	Rect cameraRect;
	float halfWidth;
	float halfHeight;

	// sound effects support
	AudioSource damageSound;
	AudioSource deathSound;
	AudioSource shootSound;

	/// <summary>
	/// Gets and sets the health
	/// </summary>
	/// <value>health</value>
	public int Health
    {
		get { return health; }
		set
        {
			// play sound if taking damage
			if (value < health)
            {
				//damageSound.Play();
			}

			health = Mathf.Clamp(value, 0, 100);
			healthText.text = HealthPrefix + health;

			// check for death
			if (health == 0 &&
			    !burgerDead)
            {
				burgerDead = true;
				//deathSound.Play();
			}
		}
	}
        
    /// <summary>
    /// Use this for initialization
    /// </summary>
	void Start()
    {
		// calculate camera rectangle for clamping on screen
		Vector3 bottomLeft = Camera.main.ScreenToWorldPoint(new Vector3(
			0, 0, -Camera.main.transform.position.z));
		Vector3 topRight = Camera.main.ScreenToWorldPoint(new Vector3(
			Screen.width, Screen.height, -Camera.main.transform.position.z));
		cameraRect = new Rect(
			bottomLeft.x,
			bottomLeft.y,
			topRight.x - bottomLeft.x,
			topRight.y - bottomLeft.y);

		// save half width and half height for efficiency
		BoxCollider2D collider = GetComponent<BoxCollider2D>();
		halfWidth = collider.size.x / 2;
		halfHeight = collider.size.y / 2;

		// save audio sources
		AudioSource[] audioSources = gameObject.GetComponents<AudioSource>();
		foreach (AudioSource audioSource in audioSources)
        {			
			if (audioSource.clip.name == "BurgerDamage")
            {				
				damageSound = audioSource;
			} 
            else if (audioSource.clip.name == "BurgerDeath")
            {				
				deathSound = audioSource;			
			}
            else if (audioSource.clip.name == "BurgerShot")
            {				
				shootSound = audioSource;
			}
		}

		// save health text and set initial text
		healthText = GameObject.Find("health").GetComponent<GUIText>();
		healthText.text = HealthPrefix + health;
	}
	
    /// <summary>
    /// Update is called once per frame
    /// </summary>
	void Update()
    {	
		// burger should only respond to input if it still has health
		if (health > 0)
        {
			// move burger using keyboard
			Vector3 pos = transform.position;
			pos.x += Input.GetAxis("Horizontal") * ConfigurationUtils.BurgerMoveUnitsPerSecond *
                Time.deltaTime;
			pos.y += Input.GetAxis("Vertical") * ConfigurationUtils.BurgerMoveUnitsPerSecond *
                Time.deltaTime;
			transform.position = pos;

			// clamp burger in window
			pos.x = Mathf.Clamp(transform.position.x, cameraRect.xMin + halfWidth, cameraRect.xMax - halfWidth);
			pos.y = Mathf.Clamp(transform.position.y, cameraRect.yMin + halfHeight, cameraRect.yMax - halfHeight);
			transform.position = pos;

			// update shooting allowed
			// timer concept (for animations) introduced in Chapter 7
			if (!canShoot)
            {
				elapsedCooldownTime += Time.deltaTime;
				if (elapsedCooldownTime >= ConfigurationUtils.BurgerCooldownSeconds ||
				    Input.GetAxis("Fire1") == 0)
                {
					canShoot = true;
					elapsedCooldownTime = 0;
				}
			}
		
			// shoot if appropriate
			if (Input.GetAxis("Fire1") != 0 &&
			    canShoot)
            {
				canShoot = false;
			
				// create and place projectile
				GameObject projectile = Instantiate(prefabProjectile) as GameObject;
				Vector3 projectilePos = transform.position;
				projectilePos.y += FrenchFriesProjectileOffset;
				projectile.transform.position = projectilePos;

				// shoot projectile up
				Rigidbody2D rb2D = projectile.GetComponent<Rigidbody2D>();
				rb2D.AddForce(new Vector2(0, ConfigurationUtils.FrenchFriesProjectileImpulseForce),
				              ForceMode2D.Impulse);

				// play sound effect
				//shootSound.Play();
			}
		}
	}

    /// <summary>
    /// Called on a collision enter
    /// </summary>
    /// <param name="coll">collision info</param>
	void OnCollisionEnter2D(Collision2D coll)
    {
		// check for collision with a teddy bear
		if (coll.gameObject.tag == "TeddyBear")
        {
			Health -= ConfigurationUtils.BearDamage;
			Instantiate(prefabExplosion, coll.transform.position, Quaternion.identity);
			Destroy(coll.gameObject);
		}
	}
}
