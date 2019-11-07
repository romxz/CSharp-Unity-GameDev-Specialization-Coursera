using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Initializes the game
/// </summary>
public class GameInitializer : MonoBehaviour
{
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
		EventManager.Initialize();
		DifficultyUtils.Initialize();
		ConfigurationUtils.Initialize();
	}
}
