using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
    #region Fields

    // score support
    [SerializeField]
    Text scoreText;
    int score = 0;
    const string ScorePrefix = "Score: ";

    #endregion

    // Start is called before the first frame update
    void Start() {
        // add as listener for PointsAddedEvent
        EventManager.AddListener(HandlePointsAddedEvent);

        // initialize score text
        scoreText.text = ScorePrefix + score;
    }

    // Update is called once per frame
    void Update() {
        
    }

    #region Private methods
    void HandlePointsAddedEvent(int points) {
        score += points;
        scoreText.text = ScorePrefix + score;
    }
    #endregion
}
