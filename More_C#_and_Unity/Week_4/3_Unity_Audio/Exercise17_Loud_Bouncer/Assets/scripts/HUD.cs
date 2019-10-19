using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The HUD
/// </summary>
public class HUD : MonoBehaviour
{
    // bounce count support
    [SerializeField]
    Text bounceText;
    int bounces = 0;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        bounceText.text = bounces.ToString();
	}
	
    /// <summary>
    /// Adds a bounce to the bounce counter
    /// </summary>
    public void AddBounce()
    {
        bounces++;
        bounceText.text = bounces.ToString();
    }
}
