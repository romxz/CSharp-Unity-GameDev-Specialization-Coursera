using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Provides difficulty-specific utilities
/// </summary>
public static class DifficultyUtils
{
	#region Fields

	static Difficulty difficulty;

	#endregion

	#region Public methods

	/// <summary>
	/// Initializes the difficulty utils
	/// </summary>
	public static void Initialize()
    {
		EventManager.AddListener(EventName.GameStartedEvent,
			HandleGameStartedEvent);
	}

	#endregion

	#region Private methods

	/// <summary>
	/// Sets the difficulty and starts the game
	/// </summary>
	/// <param name="intDifficulty">int value for difficulty</param>
	static void HandleGameStartedEvent(int intDifficulty)
    {
		difficulty = (Difficulty)intDifficulty;
		SceneManager.LoadScene("Gameplay");
	}

	#endregion
}
