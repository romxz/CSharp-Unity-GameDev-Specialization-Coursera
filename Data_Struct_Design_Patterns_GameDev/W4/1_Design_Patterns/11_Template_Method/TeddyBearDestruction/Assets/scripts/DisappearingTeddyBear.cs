using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear that disappears when the mouse passes over it
/// </summary>
public class DisappearingTeddyBear : TeddyBear
{	
	#region Protected methods

	/// <summary>
	/// Destroys the teddy bear
	/// </summary>
	protected override void ProcessMouseOver()
    {
		teddyBearDestruction.AddPoints(pointValue);
		Destroy(gameObject);
	}

	#endregion
}
