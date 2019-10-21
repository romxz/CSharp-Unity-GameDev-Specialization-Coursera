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

	// spawn control
	Timer spawnTimer;

	// spawn location support
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

	// resolution support
	const int BaseWidth = 800;
	const int BaseHeight = 600;
	const int BaseBorderSize = 100;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
		float widthRatio = (float)Screen.width / BaseWidth;
		float heightRatio = (float)Screen.height / BaseHeight;
		float resolutionRatio = (widthRatio + heightRatio) / 2;
		int spawnBorderSize = (int)(BaseBorderSize * resolutionRatio);

		// save spawn boundaries for efficiency
		minSpawnX = spawnBorderSize;
		maxSpawnX = Screen.width - spawnBorderSize;
		minSpawnY = spawnBorderSize;
		maxSpawnY = Screen.height - spawnBorderSize;

		// spawn and destroy a bear to cache collider values
		GameObject tempBear = Instantiate(prefabTeddyBear) as GameObject;
		BoxCollider2D collider = tempBear.GetComponent<BoxCollider2D>();
		teddyBearColliderHalfWidth = collider.size.x / 2;
		teddyBearColliderHalfHeight = collider.size.y / 2;
		Destroy(tempBear);

		// create and start timer
		spawnTimer = gameObject.AddComponent<Timer>();
		spawnTimer.AddTimerFinishedEventListener(HandleSpawnTimerFinishedEvent);
		StartRandomTimer();
	}

	/// <summary>
	/// Handles the spawn timer finished event
	/// </summary>
	private void HandleSpawnTimerFinishedEvent()
    {
		// only spawn a bear if below max number
		if (GameObject.FindGameObjectsWithTag("TeddyBear").Length <
		    ConfigurationUtils.MaxNumBears)
        {
			SpawnBear();
		}

		// change spawn timer duration and restart
		StartRandomTimer();
	}

	/// <summary>
	/// Spawns a new teddy bear at a random location
	/// </summary>
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
		if (Physics2D.OverlapArea(min, max) == null)
        {
			GameObject teddyBear = Instantiate(prefabTeddyBear) as GameObject;
			teddyBear.transform.position = worldLocation;
		}
	}

	/// <summary>
	/// Starts the timer with a random duration
	/// </summary>
	void StartRandomTimer()
    {
		spawnTimer.Duration = Random.Range(ConfigurationUtils.MinSpawnDelay, 
			ConfigurationUtils.MaxSpawnDelay);
		spawnTimer.Run();
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
