using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A fish
/// </summary>
public class Fish : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;

    int damage = 100;

    /// <summary>
    /// Gets the damage inflicted by the fish
    /// </summary>
    /// <value>damage</value>
    public int Damage
    {
        get { return damage; }
    }

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		
	}
}
