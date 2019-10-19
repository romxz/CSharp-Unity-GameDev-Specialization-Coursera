using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A fish squadron
/// </summary>
public class FishSquadron : MonoBehaviour
{
    [SerializeField]
    GameObject prefabFish;

    // placement support
    GameObject[] fish;
    float[] xPositions;
    float baseY;

    // save for efficiency
    int numFish;
    Vector2 fishLocation = Vector2.zero;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
    {
        // retrieve fish size
        GameObject tempFish = Instantiate<GameObject>(prefabFish);
        BoxCollider2D collider = tempFish.GetComponent<BoxCollider2D>();
        float fishWidth = collider.size.x;
        float fishHeight = collider.size.y;
        Destroy(tempFish);

        // calculate fish in row and make sure left fish position centers row
        float screenWidth = ScreenUtils.ScreenRight - ScreenUtils.ScreenLeft;
        numFish = (int)(screenWidth / fishWidth);
        float totalFishWidth = numFish * fishWidth;
        float leftFishOffset = ScreenUtils.ScreenLeft +
                               (screenWidth - totalFishWidth) / 2 +
                               fishWidth / 2;

        // save y location for fish and create arrays
        baseY = ScreenUtils.ScreenBottom + fishHeight / 2;
        fish = new GameObject[numFish];
        xPositions = new float[numFish];

        // add row of fish
        fishLocation = new Vector2(leftFishOffset, baseY);
        int fishIndex = 0;
        for (int column = 0; column < numFish; column++)
        {
            fish[fishIndex] = Instantiate<GameObject>(prefabFish, 
                fishLocation, Quaternion.identity);
            xPositions[fishIndex] = fishLocation.x;
            fishLocation.x += fishWidth;
            fishIndex++;
        }
    }
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		// replace any fish that have been killed
        for (int i = 0; i < numFish; i++)
        {
            if (fish[i] == null)
            {
                fishLocation.x = xPositions[i];
                fish[i] = Instantiate<GameObject>(prefabFish, 
                    fishLocation, Quaternion.identity);
            }
        }
	}
}
