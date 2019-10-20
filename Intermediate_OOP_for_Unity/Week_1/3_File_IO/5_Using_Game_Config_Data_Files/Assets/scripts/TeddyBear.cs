using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour {
	
	// projectile
	public GameObject prefabProjectile;

	// shooting support
	float elapsedShotTime = 0;
	float firingDelay;
    const float TeddyBearProjectileOffset = 0.2f;
	
	// sound effects support
	AudioSource bounceSound;
	AudioSource shootSound;

    /// <summary>
    /// Gets the location of the teddy bear
    /// </summary>
    public Vector2 Location
    {
        get { return transform.position; }
    }

    /// <summary>
    /// Use this for initialization
    /// </summary>
	void Start()
    {	
		firingDelay = GetRandomFiringDelay();
		
		// save audio sources
		AudioSource[] audioSources = gameObject.GetComponents<AudioSource>();
		foreach (AudioSource audioSource in audioSources)
        {		
			if (audioSource.clip.name == "TeddyBounce")
            {
				bounceSound = audioSource;
			} 
            else if (audioSource.clip.name == "TeddyShot")
            {
				shootSound = audioSource;
			}
		}
	}
	
    /// <summary>
    /// Update is called once per frame
    /// </summary>
	void Update()
    {	
		// fire projectile as appropriate
		// timer concept (for animations) introduced in Chapter 7
		elapsedShotTime += Time.deltaTime;
		if (elapsedShotTime >= firingDelay)
        {
			elapsedShotTime = 0;
			firingDelay = GetRandomFiringDelay();

			// create and place projectile
			GameObject projectile = Instantiate(prefabProjectile) as GameObject;
			Vector3 projectilePos = transform.position;
			projectilePos.y -= TeddyBearProjectileOffset;
			projectile.transform.position = projectilePos;
			
			// shoot projectile up
			Rigidbody2D rb2D = projectile.GetComponent<Rigidbody2D>();
			rb2D.AddForce(new Vector2(0, - ConfigurationUtils.TeddyBearProjectileImpulseForce),
                ForceMode2D.Impulse);

			// play sound effect
			//shootSound.Play();
		}
	}
        
    /// <summary>
    /// Called on a collision
    /// </summary>
    /// <param name="coll">collision info</param>
	void OnCollisionEnter2D(Collision2D coll)
    {
		// play bounce sound effect, but only for collisions
		// with the main camera or another teddy bear
		if (coll.gameObject.tag == "MainCamera" ||
		    coll.gameObject.tag == "TeddyBear")
        {
			//bounceSound.Play();
		}

	}

	/// <summary>
	/// Gets a random firing delay between MIN_FIRING_DELAY and
	/// MIN_FIRING_DELY + FIRING_RATE_RANGE
	/// </summary>
	/// <returns>the random firing delay</returns>
	private float GetRandomFiringDelay()
	{
		return Random.Range(ConfigurationUtils.BearMinFiringDelay, 
            ConfigurationUtils.BearMinFiringDelay + ConfigurationUtils.BearFiringRateRange);
	}
}
