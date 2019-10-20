using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
    // scoring support
    [SerializeField]
    Text scoreText;
    int score;
    const string ScorePrefix = "Score: ";

    // Start is called before the first frame update
    void Start() {
        scoreText.text = ScorePrefix + score.ToString();
    }

    // Update is called once per frame
    void Update() {
        
    }

    /// <summary>
    /// Adds given points to the score
    /// </summary>
    /// <param name="points"></param>
    public void AddPoints(int points) {
        score += points;
        scoreText.text = ScorePrefix + score.ToString();
    }
}
