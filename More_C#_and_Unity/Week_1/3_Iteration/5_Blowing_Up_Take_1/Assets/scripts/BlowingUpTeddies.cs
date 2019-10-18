using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Blows up teddies in response to player input
/// </summary>
public class BlowingUpTeddies : MonoBehaviour
{
	[SerializeField]
	GameObject prefabExplosion;

	[SerializeField]
	Sprite yellowTeddySprite;
	[SerializeField]
	Sprite greenTeddySprite;
	[SerializeField]
	Sprite purpleTeddySprite;

	List<GameObject> gameObjects = new List<GameObject>();

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
		// FindObjectsOfType is slow, so only call it
		// if at least one of the axes has input
		if (Input.GetAxis("BlowUpYellowTeddies") > 0 ||
			Input.GetAxis("BlowUpGreenTeddies") > 0 ||
			Input.GetAxis("BlowUpPurpleTeddies") > 0)
        {
			gameObjects.Clear();
			gameObjects.AddRange(Object.FindObjectsOfType<GameObject>());
		}

		// blow up teddies as appropriate
		if (Input.GetAxis("BlowUpYellowTeddies") > 0)
        {
			BlowUpTeddies(TeddyColor.Yellow, gameObjects);
		}
		if (Input.GetAxis("BlowUpGreenTeddies") > 0)
        {
			BlowUpTeddies(TeddyColor.Green, gameObjects);
		}
		if (Input.GetAxis("BlowUpPurpleTeddies") > 0)
        {
			BlowUpTeddies(TeddyColor.Purple, gameObjects);
		}
	}

	/// <summary>
	/// Blows up all the teddies of the given color
	/// </summary>
	/// <param name="color">color</param>
	/// <param name="gameObjects">the game objects in the scene</param>
	void BlowUpTeddies(TeddyColor color, List<GameObject> gameObjects)
    {
        // blow up teddies of the given color
		for (int i = gameObjects.Count - 1; i >= 0; i--)
        {
			SpriteRenderer spriteRenderer = gameObjects[i].GetComponent<SpriteRenderer>();
			if (spriteRenderer != null)
            {
				Sprite sprite = spriteRenderer.sprite;
				if ((color == TeddyColor.Green && sprite == greenTeddySprite) ||
					(color == TeddyColor.Purple && sprite == purpleTeddySprite) ||
					(color == TeddyColor.Yellow && sprite == yellowTeddySprite))
                {
					BlowUpTeddy(gameObjects[i]);
				}
			}
		}
	}

	/// <summary>
	/// Blows up the given teddy
	/// </summary>
	/// <param name="teddy">the teddy to blow up</param>
	void BlowUpTeddy(GameObject teddy)
    {
		Instantiate(prefabExplosion, teddy.transform.position, Quaternion.identity);
		Destroy(teddy);
	}
}
