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
		MenuManager.GoToMenu(MenuName.Main);
	}
}
