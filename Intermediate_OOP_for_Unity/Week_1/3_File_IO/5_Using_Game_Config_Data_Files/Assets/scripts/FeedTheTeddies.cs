using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Game manager
/// </summary>
public class FeedTheTeddies : MonoBehaviour
{
	public GameObject prefabTeddyBear;

	// score support
	float score = 0;
	GUIText scoreText;
    const string ScorePrefix = "Score: ";

	// cached for efficiency
	float teddyBearColliderHalfWidth;
	float teddyBearColliderHalfHeight;

	// spawn support, cached for efficiency
	int minSpawnX;
	int maxSpawnX;
	int minSpawnY;
	int maxSpawnY;
    const int SpawnBorderSize = 100;

    /// <summary>
    /// Use this for initialization
    /// </summary>
	void Start()
    {	
		// save score text and set initial text
		scoreText = GameObject.Find("score").GetComponent<GUIText>();
		scoreText.text = ScorePrefix + score;

		// save spawn boundaries for efficiency
		minSpawnX = SpawnBorderSize;
		maxSpawnX = Screen.width - SpawnBorderSize;
		minSpawnY = SpawnBorderSize;
		maxSpawnY = Screen.height - SpawnBorderSize;

		// spawn and destroy a bear to cache collider values
		GameObject tempBear = Instantiate(prefabTeddyBear) as GameObject;
		BoxCollider2D collider = tempBear.GetComponent<BoxCollider2D>();
		Vector3 diff = collider.bounds.max - collider.bounds.min;
		teddyBearColliderHalfWidth = diff.x / 2;
		teddyBearColliderHalfHeight = diff.y / 2;
		Destroy ( tempBear );

		// spawn bears
		for (int i = 0; i < ConfigurationUtils.MaxBears; i++ )
        {
			SpawnBear();
		}
	}
	
	/// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {	
		// spawn new bears as necessary
		int numBears = GameObject.FindGameObjectsWithTag("TeddyBear").Length;
		for (int i = ConfigurationUtils.MaxBears - numBears; i > 0; i--)
        {
			SpawnBear();
		}
	}

    /// <summary>
    /// Adds the given points to the score
    /// </summary>
    /// <param name="points">points to add</param>
	public void AddPoints(int points)
    {
		score += points;
		scoreText.text = ScorePrefix + score;
	}
        
    /// <summary>
    /// Spawns a new teddy bear at a random location
    /// </summary>
	private void SpawnBear()
	{
		// generate random location and calculate teddy bear collision rectangle
		Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
		    Random.Range(minSpawnY, maxSpawnY),
		    -Camera.main.transform.position.z);
		Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
		Vector2 min = new Vector2(worldLocation.x - teddyBearColliderHalfWidth,
		    worldLocation.y - teddyBearColliderHalfHeight);
		Vector2 max = new Vector2(worldLocation.x + teddyBearColliderHalfWidth,
		    worldLocation.y + teddyBearColliderHalfHeight);

		// make sure we don't spawn into a collision
		while (Physics2D.OverlapArea(min, max) != null )
        {
			// change location and calculate new rectangle points
			location.x = Random.Range(minSpawnX, maxSpawnX);
			location.y = Random.Range(minSpawnY, maxSpawnY);
			worldLocation = Camera.main.ScreenToWorldPoint(location);
			min.x = worldLocation.x - teddyBearColliderHalfWidth;
			min.y = worldLocation.y - teddyBearColliderHalfHeight;
			max.x = worldLocation.x + teddyBearColliderHalfWidth;
			max.y = worldLocation.y + teddyBearColliderHalfHeight;
		}

		// create new bear
		GameObject teddyBear = Instantiate(prefabTeddyBear) as GameObject;
		teddyBear.transform.position = worldLocation;

		// generate random initial force and move new bear
		Vector2 initialForce = Random.insideUnitCircle * 
			ConfigurationUtils.BearMaxImpulseForce;
		Rigidbody2D rb2D = teddyBear.GetComponent<Rigidbody2D>();
		rb2D.AddForce(initialForce, ForceMode2D.Impulse);
	}
	
	/// <summary>
	/// Gets a random location using the given min and range
	/// </summary>
	/// <param name="min">the minimum</param>
	/// <param name="range">the range</param>
	/// <returns>the random location</returns>
	private int GetRandomLocation(int min, int range)
	{
		return Random.Range (min, min + range);
	}
}
