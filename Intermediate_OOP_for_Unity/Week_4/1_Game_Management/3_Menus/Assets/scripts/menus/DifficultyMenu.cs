﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Listens for the OnClick events for the difficulty menu buttons
/// </summary>
public class DifficultyMenu : IntEventInvoker {
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start() {
        // add event component and add invoker to event manager
        unityEvent = new GameStartedEvent();
        EventManager.AddInvoker(EventName.GameStartedEvent, this);
    }

    /// <summary>
    /// Handles the on click event from the easy button
    /// </summary>
    public void HandleEasyButtonOnClickEvent() {
        unityEvent.Invoke((int)Difficulty.Easy);
    }

    /// <summary>
    /// Handles the on click event from the medium button
    /// </summary>
    public void HandleMediumButtonOnClickEvent() {
        unityEvent.Invoke((int)Difficulty.Medium);
    }

    /// <summary>
    /// Handles the on click event from the hard button
    /// </summary>
    public void HandleHardButtonOnClickEvent() {
        unityEvent.Invoke((int)Difficulty.Hard);
    }
}
