using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An apple spawner
/// </summary>
public class AppleSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabApple;

    // spawn support
    Timer spawnTimer;
    const float SpawnDelaySeconds = 1;

    // spawn location support
    float spawnY;
    float minSpawnX;
    float maxSpawnX;
    const float SpawnBorder = 0.5f;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		// get apple collider radius
        GameObject tempApple = Instantiate<GameObject>(prefabApple);
        CircleCollider2D appleCollider = tempApple.GetComponent<CircleCollider2D>();
        float appleRadius = appleCollider.radius;
        Destroy(tempApple);

        // save spawn location information for efficiency
        Vector3 topLeftCorner = new Vector3(0, Screen.height, 
            -Camera.main.transform.position.z);
        Vector3 bottomRightCorner = new Vector3(Screen.width,
            0, -Camera.main.transform.position.z);
        Vector3 worldTopLeftCorner = Camera.main.ScreenToWorldPoint(topLeftCorner);
        Vector3 worldBottomRightCorner = Camera.main.ScreenToWorldPoint(bottomRightCorner);
        spawnY = worldTopLeftCorner.y + appleRadius;
        minSpawnX = worldTopLeftCorner.x + SpawnBorder;
        maxSpawnX = worldBottomRightCorner.x - SpawnBorder;

        // start spawn timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = SpawnDelaySeconds;
        spawnTimer.Run();
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // spawn apple as appropriate
        if (spawnTimer.Finished)
        {
            Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
                spawnY, 0);
            Instantiate(prefabApple, location, Quaternion.identity);
            spawnTimer.Run();
        }		
	}
}
