using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Extends MonoBehaviour to support invoking a 
/// one integer argument UnityEvent
/// </summary>
public class IntEventInvoker : MonoBehaviour
{
	protected UnityEvent<int> unityEvent;

	/// <summary>
	/// Adds the given listener for the UnityEvent
	/// </summary>
	/// <param name="listener">listener</param>
	public void AddListener(UnityAction<int> listener)
    {
		unityEvent.AddListener(listener);
	}
}
