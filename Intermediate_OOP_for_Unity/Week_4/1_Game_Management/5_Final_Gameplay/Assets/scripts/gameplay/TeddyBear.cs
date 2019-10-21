using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
	// shooting support
	[SerializeField]
	GameObject prefabTeddyBearProjectile;
	Timer shootTimer;
	const float TeddyBearProjectilePositionOffset = 0.5f;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // apply impulse force to get teddy bear moving
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(ConfigurationUtils.MinImpulseForce,
            ConfigurationUtils.MaxImpulseForce);
        Vector2 force = direction * magnitude;
        GetComponent<Rigidbody2D>().AddForce(force,
            ForceMode2D.Impulse);

        // initialize homing component
        HomingComponent homingComponent = GetComponent<HomingComponent>();
		homingComponent.SetImpulseForce(force.magnitude);

		// create and start timer
		shootTimer = gameObject.AddComponent<Timer>();
		shootTimer.AddTimerFinishedEventListener(HandleTimerFinishedEvent);
		StartRandomTimer();
	}

	/// <summary>
	/// Shoots a teddy bear projectile, resets the timer
	/// duration, and restarts the timer
	/// </summary>
	void HandleTimerFinishedEvent()
    {
		// shoot a teddy bear projectile
		Vector3 projectilePos = transform.position;
		projectilePos.y -= TeddyBearProjectilePositionOffset;
		Instantiate(prefabTeddyBearProjectile, projectilePos, 
			Quaternion.identity);
		
		// change timer duration and restart
		StartRandomTimer();
	}

	/// <summary>
	/// Starts the timer with a random duration
	/// </summary>
	void StartRandomTimer()
    {
		shootTimer.Duration = Random.Range(ConfigurationUtils.BearMinShotDelay, 
			ConfigurationUtils.BearMaxShotDelay);
		shootTimer.Run();
	}
}
