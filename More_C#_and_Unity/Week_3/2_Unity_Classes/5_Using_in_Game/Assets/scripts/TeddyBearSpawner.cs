using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear spawner
/// </summary>
public class TeddyBearSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabTeddyBear;

    // spawn timing support
    const float SpawnDelaySeconds = 2;
    Timer spawnTimer;

    // spawn location support
    float spawnMinX;
    float spawnMaxX;
    Vector2 spawnLocation = Vector2.zero;

    /// <summary>
    /// Awake is called before Start
    /// </summary>
    void Awake()
    {
        ScreenUtils.Initialize();
    }

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // retrieve teddy bear size
        GameObject tempTeddyBear = Instantiate<GameObject>(prefabTeddyBear);
        BoxCollider2D collider = tempTeddyBear.GetComponent<BoxCollider2D>();
        float teddyBearWidth = collider.size.x;
        float teddyBearHeight = collider.size.y;
        Destroy(tempTeddyBear);

        // set spawn location info
        spawnMinX = ScreenUtils.ScreenLeft + teddyBearWidth / 2;
        spawnMaxX = ScreenUtils.ScreenRight - teddyBearWidth / 2;
        spawnLocation.y = ScreenUtils.ScreenTop + teddyBearHeight / 2; 

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
		// spawn a teddy bear as appropriate
        if (spawnTimer.Finished)
        {
            spawnTimer.Run();
            spawnLocation.x = Random.Range(spawnMinX, spawnMaxX);
            Instantiate(prefabTeddyBear, spawnLocation, Quaternion.identity);
        }
	}
}
