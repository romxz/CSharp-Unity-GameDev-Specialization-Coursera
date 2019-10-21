using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Pauses and unpauses the game. Listens for the OnClick 
/// events for the pause menu buttons
/// </summary>
public class PauseMenu : MonoBehaviour
{
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {   
        // pause the game when added to the scene
        Time.timeScale = 0;
    }

    /// <summary>
    /// Handles the on click event from the Resume button
    /// </summary>
    public void HandleResumeButtonOnClickEvent()
    {
        // unpause game and destroy menu
        Time.timeScale = 1;
        Destroy(gameObject);
    }

    /// <summary>
    /// Handles the on click event from the Quit button
    /// </summary>
    public void HandleQuitButtonOnClickEvent()
    {
        // unpause game, destroy menu, and go to main menu
        Time.timeScale = 1;
        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.Main);
    }
}
