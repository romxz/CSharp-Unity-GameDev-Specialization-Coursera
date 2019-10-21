using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Game manager
/// </summary>
public class FeedTheTeddies : IntEventInvoker
{
	#region Fields

	// game timer support
	Timer gameTimer;

	// high score menu support
	[SerializeField]
	GameObject hud;

    #endregion

    /// <summary>
    /// Awake is called before Start
    /// </summary>
    void Awake()
    {
		// create and start game timer
		gameTimer = gameObject.AddComponent<Timer>();
		gameTimer.AddTimerFinishedEventListener(HandleGameTimerFinishedEvent);
		gameTimer.Duration = ConfigurationUtils.TotalGameSeconds;
		gameTimer.Run();

		// add self as timer changed event invoker
		unityEvents.Add(EventName.TimerChangedEvent, gameTimer.TimerChangedEvent);
		EventManager.AddInvoker(EventName.TimerChangedEvent, this);

		// add listener for game over event
		EventManager.AddListener(EventName.GameOverEvent, HandleGameOverEvent);
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {	
		// check for pausing game
		if (Input.GetKeyDown("escape"))
        {
			MenuManager.GoToMenu(MenuName.Pause);
		}
	}

	#region Private methods

	/// <summary>
	/// Handles the game timer finished event
	/// </summary>
	void HandleGameTimerFinishedEvent()
    {
		EndGame();
	}

	/// <summary>
	/// Handles the game over event
	/// </summary>
	/// <param name="unused">unused</param>
	void HandleGameOverEvent(int unused)
    {
		EndGame();
	}

	/// <summary>
	/// Ends the game
	/// </summary>
	void EndGame()
    {
		SetHighScore();
		MenuManager.GoToMenu(MenuName.HighScore);
	}

	/// <summary>
	/// Sets the saved high score if we have a new or first high score
	/// </summary>
	void SetHighScore()
    {
		HUD hudScript = hud.GetComponent<HUD>();
		int currentScore = hudScript.Score;
		if (PlayerPrefs.HasKey("High Score"))
        {
			if (currentScore > PlayerPrefs.GetInt("High Score"))
            {
				PlayerPrefs.SetInt("High Score", currentScore);
                PlayerPrefs.Save();
			}
		}
        else
        {
			PlayerPrefs.SetInt("High Score", currentScore);
            PlayerPrefs.Save();
        }
    }

	#endregion
}
