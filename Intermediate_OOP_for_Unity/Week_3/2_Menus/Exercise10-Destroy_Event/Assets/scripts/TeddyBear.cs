using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        EventManager.AddDestroyEventListener(HandleDestroyEvent);
	}

    /// <summary>
    /// Destroys the teddy bear
    /// </summary>
    void HandleDestroyEvent()
    {
        Destroy(gameObject);
    }
}
