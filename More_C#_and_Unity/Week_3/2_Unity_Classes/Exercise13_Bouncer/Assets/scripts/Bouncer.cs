using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A bouncer
/// </summary>
public class Bouncer : MonoBehaviour
{
    int health = 100;

    // saved for efficiency
    SpriteRenderer spriteRenderer;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // save for efficiency
        spriteRenderer = GetComponent<SpriteRenderer>();

		// get the bouncer moving
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(3, 2), ForceMode2D.Impulse);
	}

    /// <summary>
    /// Reduce health and opacity
    /// </summary>
    /// <param name="coll">collision info</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        health -= 10;

        // reduce opacity
        Color color = spriteRenderer.color;
        color.a -= 0.1f;
        spriteRenderer.color = color;

        // destroy bouncer as appropriate
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
