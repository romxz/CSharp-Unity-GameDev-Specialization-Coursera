using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An exploding teddy bear
/// </summary>
public class ExplodingTeddyBear : AnimatedTeddyBear
{	
	#region Protected methods

	/// <summary>
	/// Explodes the teddy bear
	/// </summary>
	protected override void ProcessMouseOver()
    {
		teddyBearDestruction.AddPoints(pointValue);
		Instantiate(prefabAnimation, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

	#endregion
}
