using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A projectile
/// </summary>
public class Projectile : MonoBehaviour
{
    // projectile speed support
    protected Vector2 impulseForce = Vector2.zero;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	virtual protected void Start()
	{
		// get projectile moving
        GetComponent<Rigidbody2D>().AddForce(
            impulseForce, ForceMode2D.Impulse);
	}

    /// <summary>
    /// Destroys projectile when it leaves the screen
    /// </summary>
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
