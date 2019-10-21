using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// A fish
/// </summary>
public class Fish : MonoBehaviour
{
	[SerializeField]
	float moveUnitsPerSecond;

	// sprite processing support
	[SerializeField]
	Sprite rightFacingSprite;
	[SerializeField]
	Sprite leftFacingSprite;
	SpriteRenderer spriteRenderer;

	// head bounding box support
	Bounds headBoundingBox;
	const float HeadPercentageOfCollider = 0.2f;
	const float HeadBoundingBoxGrowthFactor = 1.4f;
	Vector3 headBoundingBoxLocation;
	float headBoundingBoxXOfsset;
	BoxCollider2D fishCollider;
	
	// collider dimensions
	float colliderHalfWidth;
	float colliderHalfHeight;
	
	// saved for efficient boundary checking
	float screenLeft;
	float screenRight;
	float screenTop;
	float screenBottom;

	// score support
	[SerializeField]
	int bearPoints;
    PointsAddedEvent pointsAddedEvent = new PointsAddedEvent();

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
		// initialize sprite processing
		spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.sprite = rightFacingSprite;

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
		fishCollider = GetComponent<BoxCollider2D>();
		Vector3 diff = fishCollider.bounds.max - fishCollider.bounds.min;
		colliderHalfWidth = diff.x / 2;
		colliderHalfHeight = diff.y / 2;

		// initialize head bounding box fields
		headBoundingBoxXOfsset = colliderHalfWidth -
			(diff.x * HeadPercentageOfCollider) / 2;
		headBoundingBoxLocation = new Vector3(
			fishCollider.transform.position.x + headBoundingBoxXOfsset,
			fishCollider.transform.position.y,
			fishCollider.transform.position.z);
		headBoundingBox = new Bounds(headBoundingBoxLocation,
			new Vector3(diff.x * HeadPercentageOfCollider * HeadBoundingBoxGrowthFactor,
		    	diff.y * HeadBoundingBoxGrowthFactor, 0));

        // add self as event invoker
        EventManager.AddInvoker(this);
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {		
		Vector3 position = transform.position;
		
		// set sprite and get new horizontal position
		float horizontalInput = Input.GetAxis("Horizontal");
		if (horizontalInput < 0)
        {
			spriteRenderer.sprite = leftFacingSprite;
			position.x += horizontalInput * moveUnitsPerSecond * 
				Time.deltaTime;
		}
        else if (horizontalInput > 0)
        {
			spriteRenderer.sprite = rightFacingSprite;
			position.x += horizontalInput * moveUnitsPerSecond * 
				Time.deltaTime;
		}
		
		// get new vertical position
		float verticalInput = Input.GetAxis("Vertical");
		if (verticalInput < 0 ||
		    verticalInput > 0)
        {
			position.y += verticalInput * moveUnitsPerSecond * 
				Time.deltaTime;
		}
		
		// move and clamp in screen
		transform.position = position;
		ClampInScreen();
	}

	/// <summary>
	/// Checks whether or not to eat a teddy bear
	/// </summary>
	/// <param name="coll">collision info</param>
	void OnCollisionEnter2D(Collision2D coll)
    {
		// move head bounding box to correct location
		headBoundingBoxLocation.y = fishCollider.transform.position.y;
		if (spriteRenderer.sprite == leftFacingSprite)
        {
			headBoundingBoxLocation.x = fishCollider.transform.position.x - 
				headBoundingBoxXOfsset;
		}
        else
        {
			headBoundingBoxLocation.x = fishCollider.transform.position.x + 
				headBoundingBoxXOfsset;
		}
		headBoundingBox.center = headBoundingBoxLocation;

		// destroy teddy bear if it collides with head bounding box
		if (coll.collider.bounds.Intersects(headBoundingBox))
        {
			Destroy(coll.gameObject);

			// update score
            pointsAddedEvent.Invoke(bearPoints);
		}
	}
	
	/// <summary>
	/// Clamps the fish in the screen
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
    /// Adds a listener for the PointsAddedEvent
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddPointsAddedEventListener(UnityAction<int> listener)
    {
        pointsAddedEvent.AddListener(listener);
    }
}
