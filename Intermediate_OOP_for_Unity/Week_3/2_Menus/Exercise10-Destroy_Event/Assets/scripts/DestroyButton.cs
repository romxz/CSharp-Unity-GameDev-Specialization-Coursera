using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// A destroy button
/// </summary>
public class DestroyButton : MonoBehaviour
{
    DestroyEvent destroyEvent = new DestroyEvent();

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        EventManager.AddDestroyEventInvoker(this);
	}
	
    /// <summary>
    /// Adds the given listener for the destroy event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddDestroyEventListener(UnityAction listener)
    {
        destroyEvent.AddListener(listener);
    }

    /// <summary>
    /// Invokes the event when the button is clicked
    /// </summary>
    public void HandleButtonClicked()
    {
        destroyEvent.Invoke();
    }
}
