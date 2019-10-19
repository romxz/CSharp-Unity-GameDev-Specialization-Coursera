using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An apple
/// </summary>
public class Apple : MonoBehaviour
{
    const int HealthValue = 10;

    /// <summary>
    /// Gets the health value for the apple
    /// </summary>
    /// <value>health value</value>
    public int Health
    {
        get { return HealthValue; }
    }
}
