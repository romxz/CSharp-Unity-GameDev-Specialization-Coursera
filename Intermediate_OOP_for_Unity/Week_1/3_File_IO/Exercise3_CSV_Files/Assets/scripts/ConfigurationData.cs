using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData {
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data with default values
    static float teddyBearMoveUnitsPerSecond = 5;//20;
    static float cooldownSeconds = 1;//.1;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the teddy bear move units per second
    /// </summary>
    /// <value>teddy bear move units per second</value>
    public float TeddyBearMoveUnitsPerSecond {
        get { return teddyBearMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the cooldown seconds for shooting
    /// </summary>
    /// <value>cooldown seconds</value>
    public float CooldownSeconds {
        get { return cooldownSeconds; }
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData() {
        // read and save configuration data from file
        StreamReader configFile = null;
        try {
            configFile = File.OpenText(Path.Combine(
                Application.streamingAssetsPath, ConfigurationDataFileName));

            string names = configFile.ReadLine();
            Debug.Log("names: " + names);
            string values = configFile.ReadLine();
            Debug.Log("values: " + values);

            // Set the fields
            SetConfigurationDataFields(values);
        } catch (Exception e) {
            Debug.Log(e.Message);
            Debug.Log("configFile: " + configFile);
        } finally {
            if (configFile != null) configFile.Close();
        }
    }


    /// <summary>
    /// Sets the configuration data fields from the provided
    /// csv string
    /// </summary>
    /// <param name="csvValues">csv string of values</param>
    static void SetConfigurationDataFields(string csvValues) {
        string[] values = csvValues.Split(',');

        teddyBearMoveUnitsPerSecond = float.Parse(values[0]);
        cooldownSeconds = float.Parse(values[1]);
        Debug.Log("Successfully loaded csv");
    }

    #endregion
}
