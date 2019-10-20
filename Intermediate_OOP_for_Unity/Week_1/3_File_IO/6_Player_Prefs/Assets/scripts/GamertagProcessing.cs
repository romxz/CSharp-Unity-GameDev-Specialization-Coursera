using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Retrieves and saves gamertag
/// </summary>
public class GamertagProcessing : MonoBehaviour
{
    // make visible in Inspector
    [SerializeField]
    Text gamertagText;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // set text to saved gamertag value or prompt
        string gamertag = PlayerPrefs.GetString("Gamertag");
        if (string.IsNullOrEmpty(gamertag))
        {
            gamertag = "Enter Gamertag ...";
        }
        InputField gamertagInputField = gamertagText.GetComponent<InputField>();
        gamertagInputField.text = gamertag;

        // add listener for changes to gamertag
        gamertagInputField.onEndEdit.AddListener(SaveGamertag);
    }

    /// <summary>
    /// Saves the gamertag
    /// </summary>
    /// <param name="gamertag">gamertag</param>
    void SaveGamertag(string gamertag)
    {
        PlayerPrefs.SetString("Gamertag", gamertag);
        PlayerPrefs.Save();
    }
}
