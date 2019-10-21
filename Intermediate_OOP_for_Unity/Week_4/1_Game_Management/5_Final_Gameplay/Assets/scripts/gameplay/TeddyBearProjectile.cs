using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear projectile
/// </summary>
public class TeddyBearProjectile : MonoBehaviour
{
	[SerializeField]
	GameObject prefabExplosion;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
		// apply impulse force to get projectile moving
		GetComponent<Rigidbody2D>().AddForce(
			new Vector2(0, -ConfigurationUtils.TeddyBearProjectileImpulseForce),
			ForceMode2D.Impulse);
		
		// initialize homing component
		HomingComponent homingComponent = GetComponent<HomingComponent>();
		homingComponent.SetImpulseForce(ConfigurationUtils.TeddyBearProjectileImpulseForce);
	}

    /// <summary>
    /// Called when the teddy bear projectile become invisible
    /// </summary>
    void OnBecameInvisible()
    {
		// destroy the game object
		Destroy(gameObject);
	}

	/// <summary>
	/// Processes trigger collisions with other game objects
	/// </summary>
	/// <param name="other">information about the other collider</param>
	void OnTriggerEnter2D(Collider2D other)
    {
		// if colliding with teddy bear, destroy self
		if (other.gameObject.CompareTag("TeddyBear"))
        {
			Instantiate(prefabExplosion, 
				transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
        else if (other.gameObject.CompareTag("TeddyBearProjectile"))
        {
			// if colliding with teddy bear projectile, destroy projectile and self
			Instantiate(prefabExplosion, 
				other.gameObject.transform.position, Quaternion.identity);
			Destroy(other.gameObject);
			Instantiate(prefabExplosion, 
				transform.position, Quaternion.identity);
			Destroy(gameObject);
		} 
	}
}
