using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using UnityEngine;

/// <summary>
/// A class providing access to configuration data
/// </summary>
[DataContract]
public class ConfigurationData
{
	#region Fields

	[DataMember(Order = 0)]
	int totalGameSeconds = 30;

	[DataMember(Order = 1)]
	float burgerMoveUnitsPerSecond = 5f;

	[DataMember(Order = 2)]
	float easyMinSpawnDelay = 1f;

	[DataMember(Order = 3)]
	float mediumMinSpawnDelay = 0.5f;

	[DataMember(Order = 4)]
	float hardMinSpawnDelay = 0.25f;

	[DataMember(Order = 5)]
	float easyMaxSpawnDelay = 3f;

	[DataMember(Order = 6)]
	float mediumMaxSpawnDelay = 2f;

	[DataMember(Order = 7)]
	float hardMaxSpawnDelay = 1f;

	[DataMember(Order = 8)]
	float easyMinImpulseForce = 2f;

	[DataMember(Order = 9)]
	float mediumMinImpulseForce = 2.5f;

	[DataMember(Order = 10)]
	float hardMinImpulseForce = 3f;

	[DataMember(Order = 11)]
	float easyMaxImpulseForce = 4f;

	[DataMember(Order = 12)]
	float mediumMaxImpulseForce = 5f;

	[DataMember(Order = 13)]
	float hardMaxImpulseForce = 6f;

	[DataMember(Order = 14)]
	int easyMaxNumBears = 5;

	[DataMember(Order = 15)]
	int mediumMaxNumBears = 7;

	[DataMember(Order = 16)]
	int hardMaxNumBears = 10;

	[DataMember(Order = 17)]
	int bearDamage = 10;

	[DataMember(Order = 18)]
	float frenchFriesImpulseForce = 10f;

	[DataMember(Order = 19)]
	float burgerCooldownSeconds = 0.5f;

	[DataMember(Order = 20)]
	int bearPoints = 10;

	[DataMember(Order = 21)]
	float teddyBearProjectileImpulseForce = 5f;

	[DataMember(Order = 22)]
	float easyBearMinShotDelay = 1.5f;

	[DataMember(Order = 23)]
	float mediumBearMinShotDelay = 1f;

	[DataMember(Order = 24)]
	float hardBearMinShotDelay = 0.5f;

	[DataMember(Order = 25)]
	float easyBearMaxShotDelay = 2.5f;

	[DataMember(Order = 26)]
	float mediumBearMaxShotDelay = 2f;

	[DataMember(Order = 27)]
	float hardBearMaxShotDelay = 1.5f;

	[DataMember(Order = 28)]
	int bearProjectileDamage = 5;

	[DataMember(Order = 29)]
	float easyBearHomingDelay = 2f;

	[DataMember(Order = 30)]
	float mediumBearHomingDelay = 1.25f;

	[DataMember(Order = 31)]
	float hardBearHomingDelay = 0.5f;

	[DataMember(Order = 32)]
	float easyBearProjectileHomingDelay = 0.5f;

	[DataMember(Order = 33)]
	float mediumBearProjectileHomingDelay = 0.35f;

	[DataMember(Order = 34)]
	float hardBearProjectileHomingDelay = 0.2f;

	#endregion

	#region Properties

	/// <summary>
	/// Gets the number of seconds in a game
	/// </summary>
	public int TotalGameSeconds
    {
		get { return totalGameSeconds; }
	}

	/// <summary>
	/// Gets how many units the burger moves in a second
	/// </summary>
	/// <value>burger move units per second</value>
	public float BurgerMoveUnitsPerSecond
    {
		get { return burgerMoveUnitsPerSecond; }
	}

	/// <summary>
	/// Gets the easy min spawn delay for teddy bear spawning
	/// </summary>
	/// <value>easy minimum spawn delay</value>
	public float EasyMinSpawnDelay
    {
		get { return easyMinSpawnDelay; }
	}

	/// <summary>
	/// Gets the medium min spawn delay for teddy bear spawning
	/// </summary>
	/// <value>medium minimum spawn delay</value>
	public float MediumMinSpawnDelay
    {
		get { return mediumMinSpawnDelay; }
	}

	/// <summary>
	/// Gets the hard min spawn delay for teddy bear spawning
	/// </summary>
	/// <value>hard minimum spawn delay</value>
	public float HardMinSpawnDelay
    {
		get { return hardMinSpawnDelay; }
	}

	/// <summary>
	/// Gets the easy max spawn delay for teddy bear spawning
	/// </summary>
	/// <value>easy maximum spawn delay</value>
	public float EasyMaxSpawnDelay
    {
		get { return easyMaxSpawnDelay; }
	}

	/// <summary>
	/// Gets the medium max spawn delay for teddy bear spawning
	/// </summary>
	/// <value>medium maximum spawn delay</value>
	public float MediumMaxSpawnDelay
    {
		get { return mediumMaxSpawnDelay; }
	}

	/// <summary>
	/// Gets the hard max spawn delay for teddy bear spawning
	/// </summary>
	/// <value>hard maximum spawn delay</value>
	public float HardMaxSpawnDelay
    {
		get { return hardMaxSpawnDelay; }
	}

	/// <summary>
	/// Gets the easy min impulse force for teddy bears
	/// </summary>
	/// <value>easy minimum impulse force</value>
	public float EasyMinImpulseForce
    {
		get { return easyMinImpulseForce; }
	}

	/// <summary>
	/// Gets the medium min impulse force for teddy bears
	/// </summary>
	/// <value>medium minimum impulse force</value>
	public float MediumMinImpulseForce
    {
		get { return mediumMinImpulseForce; }
	}

	/// <summary>
	/// Gets the hard min impulse force for teddy bears
	/// </summary>
	/// <value>hard minimum impulse force</value>
	public float HardMinImpulseForce
    {
		get { return hardMinImpulseForce; }
	}

	/// <summary>
	/// Gets the easy max impulse force for teddy bears
	/// </summary>
	/// <value>easy max impulse force</value>
	public float EasyMaxImpulseForce
    {
		get { return easyMaxImpulseForce; }
	}

    /// <summary>
    /// Gets the medium max impulse force for teddy bears
    /// </summary>
    /// <value>medium max impulse force</value>
    public float MediumMaxImpulseForce
    {
		get { return mediumMaxImpulseForce; }
	}

    /// <summary>
    /// Gets the hard max impulse force for teddy bears
    /// </summary>
    /// <value>hard max impulse force</value>
    public float HardMaxImpulseForce
    {
		get { return hardMaxImpulseForce; }
	}

	/// <summary>
	/// Gets the easy max number of bears
	/// </summary>
	/// <value>easy max number bears</value>
	public int EasyMaxNumBears
    {
		get { return easyMaxNumBears; }
	}

	/// <summary>
	/// Gets the medium max number of bears
	/// </summary>
	/// <value>medium max number bears</value>
	public int MediumMaxNumBears
    {
		get { return mediumMaxNumBears; }
	}

	/// <summary>
	/// Gets the hard max number of bears
	/// </summary>
	/// <value>hard max number bears</value>
	public int HardMaxNumBears
    {
		get { return hardMaxNumBears; }
	}

	/// <summary>
	/// Gets the amount of damage a teddy bear inflicts
	/// </summary>
	/// <value>bear damage</value>
	public int BearDamage
    {
		get { return bearDamage; }
	}

	/// <summary>
	/// Gets the impulse force to apply to french fries
	/// </summary>
	/// <value>french fries impulse force</value>
	public float FrenchFriesImpulseForce
    {
		get { return frenchFriesImpulseForce; }
	}

	/// <summary>
	/// Gets the number of seconds the burger takes
	/// to cool down so it can shoot again
	/// </summary>
	/// <value>burger cooldown seconds</value>
	public float BurgerCooldownSeconds
    {
		get { return burgerCooldownSeconds; }
	}

	/// <summary>
	/// Gets how many points a bear is worth
	/// </summary>
	/// <value>bear points</value>
	public int BearPoints
    {
		get { return bearPoints; }
	}

	/// <summary>
	/// Gets the impulse force to apply to teddy bear projectiles
	/// </summary>
	/// <value>teddy bear projectile impulse force</value>
	public float TeddyBearProjectileImpulseForce
    {
		get { return teddyBearProjectileImpulseForce; }
	}
		
	/// <summary>
	/// Gets the easy minimum delay for a teddy bear to shoot
	/// a teddy bear projectile
	/// </summary>
	/// <value>easy bear minimum shot delay</value>
	public float EasyBearMinShotDelay
    {
		get { return easyBearMinShotDelay; }
	}

	/// <summary>
	/// Gets the medium minimum delay for a teddy bear to shoot
	/// a teddy bear projectile
	/// </summary>
	/// <value>medium bear minimum shot delay</value>
	public float MediumBearMinShotDelay
    {
		get { return mediumBearMinShotDelay; }
	}

	/// <summary>
	/// Gets the hard minimum delay for a teddy bear to shoot
	/// a teddy bear projectile
	/// </summary>
	/// <value>hard bear minimum shot delay</value>
	public float HardBearMinShotDelay
    {
		get { return hardBearMinShotDelay; }
	}

	/// <summary>
	/// Gets the easy maximum delay for a teddy bear to shoot
	/// a teddy bear projectile
	/// </summary>
	/// <value>easy bear maximum shot delay</value>
	public float EasyBearMaxShotDelay
    {
		get { return easyBearMaxShotDelay; }
	}

	/// <summary>
	/// Gets the medium maximum delay for a teddy bear to shoot
	/// a teddy bear projectile
	/// </summary>
	/// <value>medium bear maximum shot delay</value>
	public float MediumBearMaxShotDelay
    {
		get { return mediumBearMaxShotDelay; }
	}

	/// <summary>
	/// Gets the hard maximum delay for a teddy bear to shoot
	/// a teddy bear projectile
	/// </summary>
	/// <value>hard bear maximum shot delay</value>
	public float HardBearMaxShotDelay
    {
		get { return hardBearMaxShotDelay; }
	}

	/// <summary>
	/// Gets the amount of damage a teddy bear projectile inflicts
	/// </summary>
	/// <value>bear damage</value>
	public int BearProjectileDamage
    {
		get { return bearProjectileDamage; }
	}

	/// <summary>
	/// Gets the easy delay for a teddy bear to
	/// move toward the burger
	/// </summary>
	/// <value>easy bear homing delay</value>
	public float EasyBearHomingDelay
    {
		get { return easyBearHomingDelay; }
	}

	/// <summary>
	/// Gets the medium delay for a teddy bear to
	/// move toward the burger
	/// </summary>
	/// <value>medium bear homing delay</value>
	public float MediumBearHomingDelay
    {
		get { return mediumBearHomingDelay; }
	}

	/// <summary>
	/// Gets the hard delay for a teddy bear to
	/// move toward the burger
	/// </summary>
	/// <value>hard bear homing delay</value>
	public float HardBearHomingDelay
    {
		get { return hardBearHomingDelay; }
	}

	/// <summary>
	/// Gets the easy delay for a teddy bear projectile 
	/// to move toward the burger
	/// </summary>
	/// <value>easy bear projectile homing delay</value>
	public float EasyBearProjectileHomingDelay
    {
		get { return easyBearProjectileHomingDelay; }
	}

	/// <summary>
	/// Gets the medium delay for a teddy bear projectile
	/// to move toward the burger
	/// </summary>
	/// <value>medium bear projectile homing delay</value>
	public float MediumBearProjectileHomingDelay
    {
		get { return mediumBearProjectileHomingDelay; }
	}

	/// <summary>
	/// Gets the hard delay for a teddy bear projectile
	/// to move toward the burger
	/// </summary>
	/// <value>hard bear projectile homing delay</value>
	public float HardBearProjectileHomingDelay
    {
		get { return hardBearProjectileHomingDelay; }
	}

	#endregion

	#region Temporary development support

	/// <summary>
	/// Temporary private constructor
	/// </summary>
//	ConfigurationData()
//  {
//	}

	/// <summary>
	/// Creates an XML file that contains the default values for the configuration data
	/// 
	/// NOTE: This method should only be used during development
	/// </summary>
//	public static void SaveDefaultValues()
//  {
//		ConfigurationData defaultData = new ConfigurationData();
//		FileStream writer = new FileStream("ConfigurationData.xml", FileMode.Create);
//		DataContractSerializer ser =
//			new DataContractSerializer(typeof(ConfigurationData));
//		ser.WriteObject(writer, defaultData);
//		writer.Close();
//	}

	#endregion
}