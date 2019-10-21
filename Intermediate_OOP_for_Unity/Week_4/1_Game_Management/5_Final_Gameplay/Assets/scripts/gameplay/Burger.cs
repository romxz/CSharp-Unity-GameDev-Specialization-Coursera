using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A burger
/// </summary>
public class Burger : IntEventInvoker
{
	// saved for instantiating prefabs
	[SerializeField]
	GameObject prefabFrenchFries;
	[SerializeField]
	GameObject prefabExplosion;

	// collider dimensions
	float colliderHalfWidth;
	float colliderHalfHeight;

	// saved for efficient boundary checking
	float screenLeft;
	float screenRight;
	float screenTop;
	float screenBottom;

	// health support
	int health = 100;

	// firing support
	bool canShoot = true;
	Timer cooldownTimer;
	const float FrenchFriesPositionOffset = 0.2f;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {	
		// save screen edges in world coordinates
		float screenZ = -Camera.main.transform.position.z;
		Vector3 lowerLeftCornerScreen = new Vector3(0, 0, screenZ);
		Vector3 upperRightCornerScreen = new Vector3(
			Screen.width, Screen.height, screenZ);
		Vector3 lowerLeftCornerWorld = 
			Camera.main.ScreenToWorldPoint(lowerLeftCornerScreen);
		Vector3 upperRightCornerWorld = 
			Camera.main.ScreenToWorldPoint(upperRightCornerScreen);
		screenLeft = lowerLeftCornerWorld.x;
		screenRight = upperRightCornerWorld.x;
		screenTop = upperRightCornerWorld.y;
		screenBottom = lowerLeftCornerWorld.y;

		// save collider dimension values
		BoxCollider2D burgerCollider = GetComponent<BoxCollider2D>();
		Vector3 diff = burgerCollider.bounds.max - burgerCollider.bounds.min;
		colliderHalfWidth = diff.x / 2;
		colliderHalfHeight = diff.y / 2;

		// add as event invoker for events
		unityEvents.Add(EventName.HealthChangedEvent, new HealthChangedEvent());
		EventManager.AddInvoker(EventName.HealthChangedEvent, this);
		unityEvents.Add(EventName.GameOverEvent, new GameOverEvent());
		EventManager.AddInvoker(EventName.GameOverEvent, this);

		// set up cooldown timer
		cooldownTimer = gameObject.AddComponent<Timer>();
		cooldownTimer.Duration = ConfigurationUtils.BurgerCooldownSeconds;
		cooldownTimer.AddTimerFinishedEventListener(HandleCooldownTimerFinishedEvent);
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
		Vector3 position = transform.position;

		// get new horizontal position
		float horizontalInput = Input.GetAxis("Horizontal");
		if (horizontalInput < 0)
        {
			position.x += horizontalInput * ConfigurationUtils.BurgerMoveUnitsPerSecond * 
				Time.deltaTime;
		}
        else if (horizontalInput > 0)
        {
			position.x += horizontalInput * ConfigurationUtils.BurgerMoveUnitsPerSecond * 
				Time.deltaTime;
		}

		// get new vertical position
		float verticalInput = Input.GetAxis("Vertical");
		if (verticalInput < 0 ||
			verticalInput > 0)
        {
			position.y += verticalInput * ConfigurationUtils.BurgerMoveUnitsPerSecond * 
				Time.deltaTime;
		}

		// move and clamp in screen
		transform.position = position;
		ClampInScreen();

		// reenable shooting on Fire1 axis release
		if (!canShoot &&
			Input.GetAxisRaw ("Fire1") == 0)
        {
  			cooldownTimer.Stop();
			canShoot = true;
		}

		// shoot french fries
		if (canShoot &&
			Input.GetAxisRaw ("Fire1") != 0)
        {
   			cooldownTimer.Run();
			canShoot = false;
			Vector3 frenchFriesPos = transform.position;
			frenchFriesPos.y += FrenchFriesPositionOffset;
			Instantiate(prefabFrenchFries, frenchFriesPos, 
				Quaternion.identity);
		}
	}

	/// <summary>
	/// Processes collisions with other game objects
	/// </summary>
	/// <param name="coll">collision info</param>
	void OnCollisionEnter2D(Collision2D coll)
    {
		// if colliding with teddy bear, destroy teddy and reduce health
		if (coll.gameObject.CompareTag("TeddyBear"))
        {
			Instantiate(prefabExplosion, 
				coll.gameObject.transform.position, Quaternion.identity);
			Destroy(coll.gameObject);
			TakeDamage(ConfigurationUtils.BearDamage);
		}
	}
		
	/// <summary>
	/// Processes trigger collisions with other game objects
	/// </summary>
	/// <param name="other">information about the other collider</param>
	void OnTriggerEnter2D(Collider2D other)
    {
		// if colliding with french fries, destroy french fries
		if (other.gameObject.CompareTag("FrenchFries"))
        {
			Instantiate(prefabExplosion, 
				other.gameObject.transform.position, Quaternion.identity);
			Destroy(other.gameObject);
		}
        else if (other.gameObject.CompareTag("TeddyBearProjectile"))
        {
			// if colliding with teddy bear projectile, destroy projectile and reduce health
			Instantiate(prefabExplosion, 
				other.gameObject.transform.position, Quaternion.identity);
			Destroy(other.gameObject);
			TakeDamage(ConfigurationUtils.BearProjectileDamage);
		}
	}

	/// <summary>
	/// Clamps the burger in the screen
	/// </summary>
	void ClampInScreen()
    {
		// check boundaries and shift as necessary
		Vector3 position = transform.position;
		if (position.x - colliderHalfWidth < screenLeft)
        {
			position.x = screenLeft + colliderHalfWidth;
		}
		if (position.x + colliderHalfWidth > screenRight)
        {
			position.x = screenRight - colliderHalfWidth;
		}
		if (position.y + colliderHalfHeight > screenTop)
        {
			position.y = screenTop - colliderHalfHeight;
		}
		if (position.y - colliderHalfHeight < screenBottom)
        {
			position.y = screenBottom + colliderHalfHeight;
		}
		transform.position = position;
	}

	/// <summary>
	/// Reenables shooting when the cooldown timer finishes
	/// </summary>
	void HandleCooldownTimerFinishedEvent()
    {
		canShoot = true;
	}

	/// <summary>
	/// Reduces health by the given amount of damage
	/// </summary>
	/// <param name="damage">damage</param>
	void TakeDamage(int damage)
    {
		health = Mathf.Max(0, health - damage);
		unityEvents[EventName.HealthChangedEvent].Invoke(health);

		// check for game over
		if (health == 0)
        {
			unityEvents[EventName.GameOverEvent].Invoke(0);
		}
	}
}
