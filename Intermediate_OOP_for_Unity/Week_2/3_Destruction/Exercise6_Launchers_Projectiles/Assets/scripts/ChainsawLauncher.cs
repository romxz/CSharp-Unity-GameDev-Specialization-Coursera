using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A chainsaw launcher
/// </summary>
public class ChainsawLauncher : Launcher
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	override protected void Start()
	{
        cooldownSeconds = 2f;
        base.Start();
	}
}
