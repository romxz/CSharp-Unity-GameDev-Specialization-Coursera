using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An event listener
/// </summary>
public class Listener : MonoBehaviour {
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start() {
        // add listener for no argument event
        Invoker invoker = Camera.main.GetComponent<Invoker>();
        invoker.AddNoArgumentListener(NoArgumentHandler);

        // add listener for one argument event
        invoker.AddOneArgumentListener(OneArgumentHandler);
    }

    /// <summary>
    /// Handles the no argument event
    /// </summary>
    void NoArgumentHandler() {
        print("No Argument Event");
    }

    /// <summary>
    /// Handles the one argument event
    /// </summary>
    /// <param name="number">number</number>
    void OneArgumentHandler(int number) {
        print("Single Argument Event: " + number);
    }
}
