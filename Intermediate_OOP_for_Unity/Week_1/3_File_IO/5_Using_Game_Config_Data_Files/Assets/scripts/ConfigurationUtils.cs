using UnityEngine;
using System.Collections;

/// <summary>
/// Configuration utilities
/// </summary>
public static class ConfigurationUtils
{
    static ConfigurationData configurationData;

    #region Projectile properties

    /// <summary>
    /// Gets the teddy bear projectile impulse force
    /// </summary>
    /// <value>teddy bear projectile impulse force</value>
    public static float TeddyBearProjectileImpulseForce
    {
        get { return configurationData.TeddyBearProjectileImpulseForce; }
    }

    /// <summary>
    /// Gets the teddy bear projectile damage
    /// </summary>
    /// <value>teddy bear projectile damage</value>
    public static int TeddyBearProjectileDamage
    {
        get { return configurationData.TeddyBearProjectileDamage; }    
    }

    /// <summary>
    /// Gets the french fries projectile impulse force
    /// </summary>
    /// <value>french fries projectile impulse force</value>
    public static float FrenchFriesProjectileImpulseForce
    {
        get { return configurationData.FrenchFriesProjectileImpulseForce; }    
    }

    /// <summary>
    /// Gets the french fries projectile damage
    /// </summary>
    /// <value>french fries projectile damage</value>
    public static int FrenchFriesProjectileDamage
    {
        get { return configurationData.FrenchFriesProjectileDamage; }
    }

    #endregion

    #region Bear properties

    /// <summary>
    /// Gets the max number of bears in the game
    /// </summary>
    /// <value>max bears</value>
    public static int MaxBears
    {
        get { return configurationData.MaxBears; }    
    }

    /// <summary>
    /// Gets the number of points each bear is worth
    /// </summary>
    /// <value>bear points</value>
    public static int BearPoints
    {
        get { return configurationData.BearPoints; }    
    }

    /// <summary>
    /// Gets the amount of damage each bear inflicts
    /// </summary>
    /// <value>bear damage</value>
    public static int BearDamage
    {
        get { return configurationData.BearDamage; }
    }

    /// <summary>
    /// Gets the bear max impulse force
    /// </summary>
    /// <value>bear max impulse force</value>
    public static float BearMaxImpulseForce
    {
        get { return configurationData.BearMaxImpulseForce; }
    }

    /// <summary>
    /// Gets the bear minimum firing delay
    /// </summary>
    /// <value>bear minimum firing delay</value>
    public static float BearMinFiringDelay
    {
        get { return configurationData.BearMinFiringDelay; }    
    }

    /// <summary>
    /// Gets the bear firing rate range
    /// </summary>
    /// <value>bear firing rate range</value>
    public static float BearFiringRateRange
    {
        get { return configurationData.BearFiringRateRange; }
    }

    #endregion

    #region Burger properties

    /// <summary>
    /// Gets the burger move units per second
    /// </summary>
    /// <value>burger move units per second</value>
    public static float BurgerMoveUnitsPerSecond
    {
        get { return configurationData.BurgerMoveUnitsPerSecond; }    
    }

    /// <summary>
    /// Gets the burger cooldown seconds
    /// </summary>
    /// <value>burger cooldown seconds</value>
    public static float BurgerCooldownSeconds
    {
        get { return configurationData.BurgerCooldownSeconds; }
    }

    #endregion



    /// <summary>
    /// Initialize the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
}
