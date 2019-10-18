using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Game manager
/// </summary>
public class TedTheCollector : MonoBehaviour
{
	#region Fields

	[SerializeField]
	GameObject prefabPickup;

	TeddyBear teddyBear;
	List<GameObject> pickups = new List<GameObject>();

	#endregion

	#region Properties

	/// <summary>
	/// Gets the pickups currently in the scene
	/// </summary>
	/// <value>pickups</value>
	public List<GameObject> Pickups
    {
		get { return pickups; }
	}

    #endregion

    #region Methods

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
		// save reference for efficiency
		GameObject teddyBearGameObject = GameObject.FindGameObjectWithTag("TeddyBear");
		teddyBear = teddyBearGameObject.GetComponent<TeddyBear>();
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
		// add pickup on right click
		if (Input.GetMouseButtonDown(1))
        {
            // calculate world position of mouse click
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.z = -Camera.main.transform.position.z;
			Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

			// create pickup and add to list
			GameObject pickup = Instantiate<GameObject>(prefabPickup);
			pickup.transform.position = worldPosition;
			pickups.Add(pickup);

			// have teddy bear update its target
			teddyBear.UpdateTarget(pickup);
		}
	}

	/// <summary>
	/// Removes the given pickup from the game
	/// </summary>
	/// <param name="pickup">the pickup to remove</param>
	public void RemovePickup(GameObject pickup)
    {
		pickups.Remove(pickup);
		Destroy(pickup);
	}

	#endregion
}
