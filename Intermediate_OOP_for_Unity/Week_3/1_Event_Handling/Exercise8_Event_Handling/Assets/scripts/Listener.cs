using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An event listener
/// </summary>
public class Listener : MonoBehaviour
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		// add listener for no argument event
        Invoker invoker = Camera.main.GetComponent<Invoker>();
        invoker.AddNoArgumentListener(HandleMessageEvent);

        // add listener for one argument event
        invoker.AddOneArgumentListener(HandleCountMessageEvent);
	}
	
    /// <summary>
    /// Handles the no argument event
    /// </summary>
    void HandleMessageEvent()
    {
        print("I heard the message event");
    }

    /// <summary>
    /// Handles the one argument event
    /// </summary>
    /// <param name="number">number</number>
    void HandleCountMessageEvent(int number)
    {
        print("The event passed " + number);
    }
}
