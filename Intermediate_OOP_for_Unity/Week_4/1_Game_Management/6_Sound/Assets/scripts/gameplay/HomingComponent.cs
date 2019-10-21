using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A homing component
/// </summary>
public class HomingComponent : MonoBehaviour
{
	GameObject burger;
	new Rigidbody2D rigidbody2D;
	float impulseForce;
	float homingDelay;
	Timer homingTimer;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {	
		// save values for efficiency
		burger = GameObject.FindGameObjectWithTag("Burger");
		homingDelay = ConfigurationUtils.GetHomingDelay(gameObject.tag);
		rigidbody2D = GetComponent<Rigidbody2D>();

		// create and start timer
		homingTimer = gameObject.AddComponent<Timer>();
		homingTimer.Duration = homingDelay;
		homingTimer.AddTimerFinishedEventListener(HandleHomingTimerFinishedEvent);
		homingTimer.Run();
	}

	/// <summary>
	/// Sets the impulse force
	/// </summary>
	/// <value>impulse force</value>
	public void SetImpulseForce(float impulseForce)
    {
		this.impulseForce = impulseForce;
	}

	/// <summary>
	/// Handles the homing timer finished event
	/// </summary>
	void HandleHomingTimerFinishedEvent()
    {
		// stop moving
		rigidbody2D.velocity = Vector2.zero;

		// calculate direction to burger and start moving toward it
		Vector2 direction = new Vector2(
			burger.transform.position.x - transform.position.x,
			burger.transform.position.y - transform.position.y);
		direction.Normalize();
		rigidbody2D.AddForce(direction * impulseForce,
			ForceMode2D.Impulse);

		// restart timer
		homingTimer.Run();
	}
}
