using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // projectile characteristics
    float teddyBearProjectileImpulseForce = 8f;
    int teddyBearProjectileDamage = 5;
    float frenchFriesProjectileImpulseForce = 10f;
    int frenchFriesProjectileDamage = 5;

    // bear characteristics
    int maxBears = 5;
    int bearPoints = 10;
    int bearDamage = 10;
    float bearMaxImpulseForce = 5f;
    float bearMinFiringDelay = 0.5f;
    float bearFiringRateRange = 1f;

    // burger characteristics
    float burgerMoveUnitsPerSecond = 5;
    float burgerCooldownSeconds = 0.5f;

    #endregion

    #region Projectile properties

    /// <summary>
    /// Gets the teddy bear projectile impulse force
    /// </summary>
    /// <value>teddy bear projectile impulse force</value>
    public float TeddyBearProjectileImpulseForce
    {
        get { return teddyBearProjectileImpulseForce; }
    }

    /// <summary>
    /// Gets the teddy bear projectile damage
    /// </summary>
    /// <value>teddy bear projectile damage</value>
    public int TeddyBearProjectileDamage
    {
        get { return teddyBearProjectileDamage; }    
    }

    /// <summary>
    /// Gets the french fries projectile impulse force
    /// </summary>
    /// <value>french fries projectile impulse force</value>
    public float FrenchFriesProjectileImpulseForce
    {
        get { return frenchFriesProjectileImpulseForce; }    
    }

    /// <summary>
    /// Gets the french fries projectile damage
    /// </summary>
    /// <value>french fries projectile damage</value>
    public int FrenchFriesProjectileDamage
    {
        get { return frenchFriesProjectileDamage; }
    }

    #endregion

    #region Bear properties

    /// <summary>
    /// Gets the max number of bears in the game
    /// </summary>
    /// <value>max bears</value>
    public int MaxBears
    {
        get { return maxBears; }    
    }

    /// <summary>
    /// Gets the number of points each bear is worth
    /// </summary>
    /// <value>bear points</value>
    public int BearPoints
    {
        get { return bearPoints; }    
    }

    /// <summary>
    /// Gets the amount of damage each bear inflicts
    /// </summary>
    /// <value>bear damage</value>
    public int BearDamage
    {
        get { return bearDamage; }
    }

    /// <summary>
    /// Gets the bear max impulse force
    /// </summary>
    /// <value>bear max impulse force</value>
    public float BearMaxImpulseForce
    {
        get { return bearMaxImpulseForce; }
    }

    /// <summary>
    /// Gets the bear minimum firing delay
    /// </summary>
    /// <value>bear minimum firing delay</value>
    public float BearMinFiringDelay
    {
        get { return bearMinFiringDelay; }    
    }

    /// <summary>
    /// Gets the bear firing rate range
    /// </summary>
    /// <value>bear firing rate range</value>
    public float BearFiringRateRange
    {
        get { return bearFiringRateRange; }
    }

    #endregion

    #region Burger properties

    /// <summary>
    /// Gets the burger move units per second
    /// </summary>
    /// <value>burger move units per second</value>
    public float BurgerMoveUnitsPerSecond
    {
        get { return burgerMoveUnitsPerSecond; }    
    }

    /// <summary>
    /// Gets the burger cooldown seconds
    /// </summary>
    /// <value>burger cooldown seconds</value>
    public float BurgerCooldownSeconds
    {
        get { return burgerCooldownSeconds; }
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        // read and save configuration data from file
        StreamReader input = null;
        try
        {
            // create stream reader object
            input = File.OpenText(Path.Combine(
                Application.streamingAssetsPath, ConfigurationDataFileName));

            // read in names and values
            string names = input.ReadLine();
            string values = input.ReadLine();

            // set configuration data fields
            SetConfigurationDataFields(values);
        }
        catch (Exception e)
        {
        }
        finally
        {               
            // always close input file
            if (input != null)
            {
                input.Close();
            }
        }
    }


    /// <summary>
    /// Sets the configuration data fields from the provided
    /// csv string
    /// </summary>
    /// <param name="csvValues">csv string of values</param>
    void SetConfigurationDataFields(string csvValues)
    {
        // the code below assumes we know the order in which the
        // values appear in the string. We could do something more
        // complicated with the names and values, but that's not
        // necessary here
        string[] values = csvValues.Split(','); 

        // projectile characteristics
        teddyBearProjectileImpulseForce = float.Parse(values[0]);
        teddyBearProjectileDamage = int.Parse(values[1]);
        frenchFriesProjectileImpulseForce = float.Parse(values[2]);
        frenchFriesProjectileDamage = int.Parse(values[3]);

        // bear characteristics
        maxBears = int.Parse(values[4]);
        bearPoints = int.Parse(values[5]);
        bearDamage = int.Parse(values[6]);
        bearMaxImpulseForce = float.Parse(values[7]);
        bearMinFiringDelay = float.Parse(values[8]);
        bearFiringRateRange = float.Parse(values[9]);

        // burger characteristics
        burgerMoveUnitsPerSecond = float.Parse(values[10]);
        burgerCooldownSeconds = float.Parse(values[11]);
    }

    #endregion
}
