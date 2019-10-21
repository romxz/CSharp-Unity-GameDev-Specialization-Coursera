using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Retrieves and displays high score and listens for
/// the OnClick events for the high score menu button
/// </summary>
public class HighScoreMenu : MonoBehaviour
{
	[SerializeField]
	Text message;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
		// pause the game when added to the scene
		Time.timeScale = 0;

		// retrieve and display high score
		if (PlayerPrefs.HasKey("High Score"))
        {
			message.text = "High Score: " + PlayerPrefs.GetInt("High Score");
		}
        else
        {
			message.text = "No games played yet";
		}
	}

	/// <summary>
	/// Handles the on click event from the quit button
	/// </summary>
	public void HandleQuitButtonOnClickEvent()
    {
		// unpause game and go to main menu
		Time.timeScale = 1;
		MenuManager.GoToMenu(MenuName.Main);
	}
}
