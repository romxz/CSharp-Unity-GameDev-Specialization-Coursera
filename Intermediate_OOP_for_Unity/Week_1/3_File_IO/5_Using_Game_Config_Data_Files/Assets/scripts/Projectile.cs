using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A projectile
/// </summary>
public class Projectile : MonoBehaviour
{
	// explosion
	public GameObject prefabExplosion;

    /// <summary>
    /// Called on a 2D physics collision (because the projectile colliders are marked as triggers) 
    /// </summary>
    /// <param name="other">other collider</param>
	void OnTriggerEnter2D(Collider2D other)
    {		
		// if the collision is between french fries and a teddy bear, destroy both game objects
		if (gameObject.tag == "FrenchFriesProjectile" &&
			other.gameObject.tag == "TeddyBear")
        {
			// create explosion at teddy bear and destroy both objects
			Instantiate(prefabExplosion, other.transform.position, Quaternion.identity);
			Destroy(gameObject);
			Destroy(other.gameObject);

			// add points to score
			FeedTheTeddies ftt = Camera.main.GetComponent<FeedTheTeddies>();
			ftt.SendMessage("AddPoints", ConfigurationUtils.BearPoints);
		} 
        else if (gameObject.tag == "TeddyBearProjectile" &&
		    other.gameObject.tag == "Burger")
        {
			// create explosion at projectile, destroy projectile, and reduce burger health
			Instantiate(prefabExplosion, transform.position, Quaternion.identity);
			Destroy(gameObject);
			GameObject burgerGameObject = GameObject.FindGameObjectWithTag("Burger");
			Burger burger = burgerGameObject.GetComponent<Burger>();
			burger.Health -= ConfigurationUtils.TeddyBearProjectileDamage;
		}
	}
        
    /// <summary>
    /// Called when the projectile becomes invisible
    /// </summary>
	void OnBecameInvisible()
    {
		// destroy the game object
		Destroy(gameObject);
	}
}