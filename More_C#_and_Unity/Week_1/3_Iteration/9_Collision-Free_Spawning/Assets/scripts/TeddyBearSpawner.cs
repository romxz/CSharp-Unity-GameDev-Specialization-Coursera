using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear spawner
/// </summary>
public class TeddyBearSpawner : MonoBehaviour
{
	// needed for spawning
	[SerializeField]
	GameObject prefabTeddyBear;

	// saved for efficiency
	[SerializeField]
	Sprite teddyBearSprite0;
	[SerializeField]
	Sprite teddyBearSprite1;
	[SerializeField]
	Sprite teddyBearSprite2;

	// spawn control
	const float MinSpawnDelay = 1;
	const float MaxSpawnDelay = 2;
	Timer spawnTimer;

	// spawn location support
	const int SpawnBorderSize = 100;
	Vector3 location = new Vector3();
	int minSpawnX;
	int maxSpawnX;
	int minSpawnY;
	int maxSpawnY;

	// collision-free spawn support
	const int MaxSpawnTries = 20;
	float teddyBearColliderHalfWidth;
	float teddyBearColliderHalfHeight;
	Vector2 min = new Vector2();
	Vector2 max = new Vector2();

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {	
		// save spawn boundaries for efficiency
		minSpawnX = SpawnBorderSize;
		maxSpawnX = Screen.width - SpawnBorderSize;
		minSpawnY = SpawnBorderSize;
		maxSpawnY = Screen.height - SpawnBorderSize;

		// create and start timer
		spawnTimer = gameObject.AddComponent<Timer>();
		spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
		spawnTimer.Run();

		// spawn and destroy a bear to cache collider values
		GameObject tempBear = Instantiate(prefabTeddyBear) as GameObject;
		BoxCollider2D collider = tempBear.GetComponent<BoxCollider2D>();
		teddyBearColliderHalfWidth = collider.size.x / 2;
		teddyBearColliderHalfHeight = collider.size.y / 2;
		Destroy(tempBear);
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
		// check for time to spawn a new teddy bear
		if (spawnTimer.Finished)
        {
			SpawnBear();

			// change spawn timer duration and restart
			spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
			spawnTimer.Run();
		}
	}
	
	/// <summary>
	/// Spawns a new teddy bear at a random location
	/// </summary>
	void SpawnBear()
    {		
		// generate random location and calculate teddy bear collision rectangle
		location.x = Random.Range(minSpawnX, maxSpawnX);
		location.y = Random.Range(minSpawnY, maxSpawnY);
		location.z = -Camera.main.transform.position.z;
		Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
		SetMinAndMax(worldLocation);
		
		// make sure we don't spawn into a collision
		int spawnTries = 1;
		while (Physics2D.OverlapArea(min, max) != null &&
		       spawnTries < MaxSpawnTries)
        {			
			// change location and calculate new rectangle points
			location.x = Random.Range(minSpawnX, maxSpawnX);
			location.y = Random.Range(minSpawnY, maxSpawnY);
			worldLocation = Camera.main.ScreenToWorldPoint(location);
			SetMinAndMax(worldLocation);

			spawnTries++;
		}
		
		// create new bear if found collision-free location
		if (Physics2D.OverlapArea(min, max) == null) {
			GameObject teddyBear = Instantiate(prefabTeddyBear) as GameObject;
			teddyBear.transform.position = worldLocation;

			// set random sprite for new teddy bear
			SpriteRenderer spriteRenderer = teddyBear.GetComponent<SpriteRenderer>();
			int spriteNumber = Random.Range(0, 3);
			if (spriteNumber < 1)
            {
				spriteRenderer.sprite = teddyBearSprite0;
			}
            else if (spriteNumber < 2)
            {
				spriteRenderer.sprite = teddyBearSprite1;
			}
            else
            {
				spriteRenderer.sprite = teddyBearSprite2;
			}
		}
	}

	/// <summary>
	/// Sets min and max for a teddy bear collision rectangle
	/// </summary>
	/// <param name="location">location of the teddy bear</param>
	void SetMinAndMax(Vector3 location)
    {
		min.x = location.x - teddyBearColliderHalfWidth;
		min.y = location.y - teddyBearColliderHalfHeight;
		max.x = location.x + teddyBearColliderHalfWidth;
		max.y = location.y + teddyBearColliderHalfHeight;
	}
}
