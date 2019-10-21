using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Listens for the speak button OnClick event
/// </summary>
public class SpeakButtonListener : MonoBehaviour
{
	/// <summary>
	/// Handles the on click event from the speak button
	/// </summary>
	public void HandleOnClickEvent()
    {
		print("Hi, I've been clicked!");
	}
}
