using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A burning teddy bear
/// </summary>
public class BurningTeddyBear : AnimatedTeddyBear
{	
	#region Fields

	// burn support
	Timer burnTimer;
	const float BurnSeconds = 2f;

    #endregion

    #region Public methods

    /// <summary>
    /// Use this for initialization
    /// </summary>
    override protected void Start()
    {
		// create burn timer
		burnTimer = gameObject.AddComponent<Timer>();
		burnTimer.Duration = BurnSeconds;

		// start teddy bear moving
		base.Start();
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
		// check for burn complete
		if (burnTimer.Finished)
        {
			Destroy(gameObject);
		}
	}

	#endregion

	#region Protected methods

	/// <summary>
	/// Burns the teddy bear
	/// </summary>
	protected override void ProcessMouseOver()
    {
		if (!burnTimer.Running)
        {
			teddyBearDestruction.AddPoints (pointValue);

			// make fire animation visible
			SpriteRenderer fireRenderer = prefabAnimation.GetComponent<SpriteRenderer>();
			fireRenderer.enabled = true;

			// start burn timer
			burnTimer.Run();
		}
	}

	#endregion
}
