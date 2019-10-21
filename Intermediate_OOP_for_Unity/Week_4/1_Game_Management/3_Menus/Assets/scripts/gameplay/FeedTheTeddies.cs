using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Game manager
/// </summary>
public class FeedTheTeddies : MonoBehaviour
{
    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {	
		// check for pausing game
		if (Input.GetKeyDown(KeyCode.Escape))
        {
			MenuManager.GoToMenu(MenuName.Pause);
		}
	}
}
