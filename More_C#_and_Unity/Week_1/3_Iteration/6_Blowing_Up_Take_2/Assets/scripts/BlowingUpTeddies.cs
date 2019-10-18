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
        // blow up teddies as appropriate
		if (Input.GetAxis("BlowUpYellowTeddies") > 0)
        {
			BlowUpTeddies(TeddyColor.Yellow);
		}
		if (Input.GetAxis("BlowUpGreenTeddies") > 0)
        {
			BlowUpTeddies(TeddyColor.Green);
		}
		if (Input.GetAxis("BlowUpPurpleTeddies") > 0)
        {
			BlowUpTeddies(TeddyColor.Purple);
		}
	}

	/// <summary>
	/// Blows up all the teddies of the given color
	/// </summary>
	/// <param name="color">color</param>
	void BlowUpTeddies(TeddyColor color)
    {
        // blow up teddies of the given color
		gameObjects.Clear();
		gameObjects.AddRange(GameObject.FindGameObjectsWithTag(color.ToString()));
		for (int i = gameObjects.Count - 1; i >= 0; i--)
        {
			BlowUpTeddy(gameObjects[i]);
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
