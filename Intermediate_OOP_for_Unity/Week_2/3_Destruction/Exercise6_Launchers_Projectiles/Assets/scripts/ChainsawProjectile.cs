using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A chainsaw projectile
/// </summary>
public class ChainsawProjectile : Projectile
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	override protected void Start()
	{
        impulseForce.x = 1f;
        base.Start();
	}
}
