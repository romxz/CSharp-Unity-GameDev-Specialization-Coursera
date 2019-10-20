using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A bullet
/// </summary>
public class Bullet : MonoBehaviour
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(0, 10),
            ForceMode2D.Impulse);	
	}

    /// <summary>
    /// Destroys bullet when it leaves the screen
    /// </summary>
    void OnBecameInvisible()
    {
        Destroy(gameObject);   
    }
}
