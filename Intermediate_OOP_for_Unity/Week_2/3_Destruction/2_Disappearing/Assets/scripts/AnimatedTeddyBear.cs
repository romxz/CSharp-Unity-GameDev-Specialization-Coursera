using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear with an animation
/// </summary>
public abstract class AnimatedTeddyBear : TeddyBear
{	
	#region Fields

	[SerializeField]
	protected GameObject prefabAnimation;

	#endregion
}
