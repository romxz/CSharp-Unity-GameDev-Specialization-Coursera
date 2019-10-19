using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Prints the gamertag every second
/// </summary>
public class PrintGamertag : MonoBehaviour
{
	// make visible in Inspector
	[SerializeField]
	Text gamertagText;

	// saved for efficiency
	InputField gamertag;

	// output gamertag once per second support
	float secondsSinceLastOutput = 0;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
		gamertag = gamertagText.GetComponent<InputField>();
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {	
		// output gamertag every second
		secondsSinceLastOutput += Time.deltaTime;
		if (secondsSinceLastOutput > 1)
        {
			secondsSinceLastOutput = 0;
			print(gamertag.text);
		}
	}
}
