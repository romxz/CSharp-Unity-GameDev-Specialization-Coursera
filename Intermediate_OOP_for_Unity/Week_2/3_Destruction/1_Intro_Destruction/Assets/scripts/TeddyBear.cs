using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An abstract class for a teddy bear
/// </summary>
public abstract class TeddyBear : MonoBehaviour
{	
	#region Fields

	[SerializeField]
	protected int pointValue;

	// score support
	protected TeddyBearDestruction teddyBearDestruction;

    #endregion

    /// <summary>
    /// Use this for initialization
    /// </summary>
    virtual protected void Start()
    {		
		// apply impulse force to get teddy bear moving
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);

		// score support
		teddyBearDestruction = Camera.main.GetComponent<TeddyBearDestruction>();
	}

    /// <summary>
    /// Called when the mouse enters the collider
    /// </summary>
    void OnMouseEnter()
    {
		ProcessMouseOver();
	}

	#region Protected methods

	/// <summary>
	/// Processing for when the mouse is over the teddy bear
	/// </summary>
	protected abstract void ProcessMouseOver();

	#endregion
}