﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Game manager
/// </summary>
public class TeddyBearDestruction : MonoBehaviour {
    // score support
    [SerializeField]
    Text scoreText;
    int score = 0;
    const string ScorePrefix = "Score: ";

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start() {
        // set initial score text
        scoreText.text = ScorePrefix + score;
    }

    /// <summary>
    /// Adds the given points to the score
    /// </summary>
    /// <param name="points">points to add</param>
    public void AddPoints(int points) {
        score += points;
        scoreText.text = ScorePrefix + score;
    }
}
