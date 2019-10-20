using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves game object based on keyboard input
/// </summary>
public class Driver : MonoBehaviour
{	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // move horizontally as appropriate
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            Vector3 position = transform.position;
            position.x += horizontalInput * 
                ConfigurationUtils.TeddyBearMoveUnitsPerSecond * 
                Time.deltaTime;
            transform.position = position;
        }

        // move vertically as appropriate
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput != 0)
        {
            Vector3 position = transform.position;
            position.y += verticalInput *                 
                ConfigurationUtils.TeddyBearMoveUnitsPerSecond * 
                Time.deltaTime;
            transform.position = position;
        }
	}
}
