using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A launcher
/// </summary>
public class Launcher : MonoBehaviour
{
    [SerializeField]
    protected GameObject prefabProjectile;

    // firing rate support
    protected float cooldownSeconds;
    protected Timer cooldownTimer;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	virtual protected void Start()
	{
        // add and start cooldown timer
        cooldownTimer = gameObject.AddComponent<Timer>();
        cooldownTimer.Duration = cooldownSeconds;
        cooldownTimer.Run();
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		// shoot projectile and restart cooldown as appropriate
        if (cooldownTimer.Finished)
        {
            Instantiate(prefabProjectile, transform.position, Quaternion.identity);
            cooldownTimer.Run();
        }
	}
}
