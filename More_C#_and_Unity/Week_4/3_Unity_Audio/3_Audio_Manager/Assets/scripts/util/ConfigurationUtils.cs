using System.Collections;
using System.Collections.Generic;
//using System.IO;
//using System.Runtime.Serialization;
//using System.Xml;
using UnityEngine;

/// <summary>
/// Provides utility access to configuration data
/// </summary>
public static class ConfigurationUtils
{
	#region Fields

//	static ConfigurationData configurationData;

	#endregion

	#region Properties

	/// <summary>
	/// Gets the number of seconds in a game
	/// </summary>
	public static int TotalGameSeconds
    {
		get { return 30; }
	}

	/// <summary>
	/// Gets how many units the burger moves in a second
	/// </summary>
	/// <value>burger move units per second</value>
	public static int BurgerMoveUnitsPerSecond
    {
		get { return 5; }
	}

	/// <summary>
	/// Gets the min spawn delay for teddy bear spawning
	/// </summary>
	/// <value>minimum spawn delay</value>
	public static float MinSpawnDelay
    {
		get { return DifficultyUtils.MinSpawnDelay; }
	}

	/// <summary>
	/// Gets the max spawn delay for teddy bear spawning
	/// </summary>
	/// <value>maximum spawn delay</value>
	public static float MaxSpawnDelay
    {
		get { return DifficultyUtils.MaxSpawnDelay; }
	}
		
	/// <summary>
	/// Gets the min impulse force for teddy bears
	/// </summary>
	/// <value>minimum impulse force</value>
	public static float MinImpulseForce
    {
		get { return DifficultyUtils.MinImpulseForce; }
	}

    /// <summary>
    /// Gets the max impulse force for teddy bears
    /// </summary>
    /// <value>maximum impulse force</value>
    public static float MaxImpulseForce
    {
        get { return DifficultyUtils.MaxImpulseForce; }
    }

	/// <summary>
	/// Gets the max number of teddy bears
	/// </summary>
	/// <value>max number of teddy bears</value>
	public static int MaxNumBears
    {
		get { return DifficultyUtils.MaxNumBears; }
	}

	/// <summary>
	/// Gets the amount of damage a teddy bear inflicts
	/// </summary>
	/// <value>bear damage</value>
	public static int BearDamage
    {
		get { return 10; }
	}

	/// <summary>
	/// Gets the impulse force to apply to french fries
	/// </summary>
	/// <value>french fries impulse force</value>
	public static float FrenchFriesImpulseForce
    {
		get { return 10; }
	}

	/// <summary>
	/// Gets the number of seconds the burger takes
	/// to cool down so it can shoot again
	/// </summary>
	/// <value>burger cooldown seconds</value>
	public static float BurgerCooldownSeconds
    {
		get { return 0.5f; }
	}

	/// <summary>
	/// Gets how many points a bear is worth
	/// </summary>
	/// <value>bear points</value>
	public static int BearPoints
    {
		get { return 10; }
	}

	/// <summary>
	/// Gets the impulse force to apply to teddy bear projectiles
	/// </summary>
	/// <value>teddy bear projectile impulse force</value>
	public static float TeddyBearProjectileImpulseForce
    {
		get { return 5; }
	}

	/// <summary>
	/// Gets the minimum delay for a teddy bear to shoot
	/// a teddy bear projectile
	/// </summary>
	/// <value>bear minimum shot delay</value>
	public static float BearMinShotDelay
    {
		get { return DifficultyUtils.BearMinShotDelay; }
	}

	/// <summary>
	/// Gets the maximum delay for a teddy bear to shoot
	/// a teddy bear projectile
	/// </summary>
	/// <value>bear maximum shot delay</value>
	public static float BearMaxShotDelay
    {
		get { return DifficultyUtils.BearMaxShotDelay; }
	}
		
	/// <summary>
	/// Gets the amount of damage a teddy bear projectile inflicts
	/// </summary>
	/// <value>bear damage</value>
	public static int BearProjectileDamage
    {
		get { return 5; }
	}

    #endregion

    #region Properties that should only be used by DifficultyUtils

    /// <summary>
    /// Gets the easy min spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>easy minimum spawn delay</value>
    public static float EasyMinSpawnDelay
    {
		get { return 1; }
	}

    /// <summary>
    /// Gets the medium min spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>medium minimum spawn delay</value>
    public static float MediumMinSpawnDelay
    {
		get { return 0.5f; }
	}

    /// <summary>
    /// Gets the hard min spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>hard minimum spawn delay</value>
    public static float HardMinSpawnDelay
    {
		get { return 0.25f; }
	}

    /// <summary>
    /// Gets the easy max spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>easy maximum spawn delay</value>
    public static float EasyMaxSpawnDelay
    {
		get { return 3; }
	}

    /// <summary>
    /// Gets the medium max spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>medium maximum spawn delay</value>
    public static float MediumMaxSpawnDelay
    {
		get { return 2; }
	}

    /// <summary>
    /// Gets the hard max spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>hard maximum spawn delay</value>
    public static float HardMaxSpawnDelay
    {
		get { return 1; }
	}

    /// <summary>
    /// Gets the easy min impulse force for teddy bears
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>easy minimum impulse force</value>
    public static float EasyMinImpulseForce
    {
		get { return 2; }
	}

    /// <summary>
    /// Gets the medium min impulse force for teddy bears
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>medium minimum impulse force</value>
    public static float MediumMinImpulseForce
    {
		get { return 2.5f; }
	}

    /// <summary>
    /// Gets the hard min impulse force for teddy bears
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>hard minimum impulse force</value>
    public static float HardMinImpulseForce
    {
		get { return 3; }
	}

    /// <summary>
    /// Gets the easy max impulse force for teddy bears
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>easy maximum impulse force</value>
    public static float EasyMaxImpulseForce
    {
        get { return 4; }
    }

    /// <summary>
    /// Gets the medium max impulse force for teddy bears
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>medium maximum impulse force</value>
    public static float MediumMaxImpulseForce
    {
        get { return 5f; }
    }

    /// <summary>
    /// Gets the hard max impulse force for teddy bears
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>hard maximum impulse force</value>
    public static float HardMaxImpulseForce
    {
        get { return 6; }
    }

    /// <summary>
    /// Gets the easy max number of bears 
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>easy max number bears</value>
    public static int EasyMaxNumBears
    {
		get { return 5; }
	}

    /// <summary>
    /// Gets the medium max number of bears 
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>medium max number bears</value>
    public static int MediumMaxNumBears
    {
		get { return 7; }
	}

    /// <summary>
    /// Gets the hard max number of bears 
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>hard max number bears</value>
    public static int HardMaxNumBears
    {
		get { return 10; }
	}

    /// <summary>
    /// Gets the easy minimum delay for a teddy bear to shoot
    /// a teddy bear projectile
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>easy bear minimum shot delay</value>
    public static float EasyBearMinShotDelay
    {
		get { return 1.5f; }
	}

    /// <summary>
    /// Gets the medium minimum delay for a teddy bear to shoot
    /// a teddy bear projectile
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>medium bear minimum shot delay</value>
    public static float MediumBearMinShotDelay
    {
		get { return 1f; }
	}

    /// <summary>
    /// Gets the hard minimum delay for a teddy bear to shoot
    /// a teddy bear projectile
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>hard bear minimum shot delay</value>
    public static float HardBearMinShotDelay
    {
		get { return 0.5f; }
	}

    /// <summary>
    /// Gets the easy maximum delay for a teddy bear to shoot
    /// a teddy bear projectile
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>easy bear maximum shot delay</value>
    public static float EasyBearMaxShotDelay
    {
		get { return 2.5f; }
	}

    /// <summary>
    /// Gets the medium maximum delay for a teddy bear to shoot
    /// a teddy bear projectile
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>medium bear maximum shot delay</value>
    public static float MediumBearMaxShotDelay
    {
		get { return 2f; }
	}

    /// <summary>
    /// Gets the hard maximum delay for a teddy bear to shoot
    /// a teddy bear projectile
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>hard bear maximum shot delay</value>
    public static float HardBearMaxShotDelay
    {
		get { return 1.5f; }
	}

    /// <summary>
    /// Gets the easy delay for a teddy bear to
    /// move toward the burger
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>easy bear homing delay</value>
    public static float EasyBearHomingDelay
    {
        get { return 2f; }
    }

    /// <summary>
    /// Gets the medium delay for a teddy bear to
    /// move toward the burger
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>medium bear homing delay</value>
    public static float MediumBearHomingDelay
    {
        get { return 1.25f; }
    }

    /// <summary>
    /// Gets the hard delay for a teddy bear to
    /// move toward the burger
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>hard bear homing delay</value>
    public static float HardBearHomingDelay
    {
        get { return 0.5f; }
    }

    /// <summary>
    /// Gets the easy delay for a teddy bear projectile 
    /// to move toward the burger
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>easy bear projectile homing delay</value>
    public static float EasyBearProjectileHomingDelay
    {
        get { return 0.5f; }
    }

    /// <summary>
    /// Gets the medium delay for a teddy bear projectile
    /// to move toward the burger
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>medium bear projectile homing delay</value>
    public static float MediumBearProjectileHomingDelay
    {
        get { return 0.35f; }
    }

    /// <summary>
    /// Gets the hard delay for a teddy bear projectile
    /// to move toward the burger
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>hard bear projectile homing delay</value>
    public static float HardBearProjectileHomingDelay
    {
        get { return 0.2f; }
    }

    #endregion

    #region Public methods

    /// <summary>
    /// Initializes the configuration data by reading the data from an XML configuration file
    /// </summary>
    public static void Initialize()
    {		
		// deserialize configuration data from file into internal object
//		FileStream fs = null;
//		try 
//      {
//			fs = new FileStream("ConfigurationData.xml",
//				FileMode.Open);
//			XmlDictionaryReader reader =
//				XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
//			DataContractSerializer ser = new DataContractSerializer(typeof(ConfigurationData));
//			configurationData = (ConfigurationData)ser.ReadObject(reader, true);
//			reader.Close();
//		} 
//      finally 
//      {
//			// always close input file
//			if (fs != null) 
//          {
//				fs.Close();
//			}
//		}
	}

    /// <summary>
    /// Gets the homing delay for the given tag
    /// </summary>
    /// <returns>homing delay</returns>
    /// <param name="tag">tag</param>
    public static float GetHomingDelay(string tag)
    {
        return DifficultyUtils.GetHomingDelay(tag);
    }

    #endregion
}
