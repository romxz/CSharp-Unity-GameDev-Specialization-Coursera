using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A bouncer
/// </summary>
public class Bouncer : MonoBehaviour
{
    // saved for efficiency
    HUD hud;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // save for efficiency
        GameObject hudGameObject = GameObject.FindGameObjectWithTag("HUD");
        hud = hudGameObject.GetComponent<HUD>();

		// get the bouncer moving
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(3, 2), ForceMode2D.Impulse);
	}

    /// <summary>
    /// Update bounce count
    /// </summary>
    /// <param name="coll">collision info</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        hud.AddBounce();
    }
}
