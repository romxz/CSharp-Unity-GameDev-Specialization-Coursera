using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawn balls
/// </summary>
public class BallSpawner : MonoBehaviour {
    [SerializeField]
    Ball ball;
    [SerializeField]
    GreenBall greenBall;
    [SerializeField]
    RedBall redBall;
    
    Timer spawnTimer;

    // Start is called before the first frame update
    void Start() {
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 1;
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update() {
        if (spawnTimer.Finished) {
            int i = Random.Range(0, 3);
            if (i == 0) Instantiate<Ball>(ball);
            else if (i == 1) Instantiate<GreenBall>(greenBall);
            else Instantiate<RedBall>(redBall);
            spawnTimer.Run();
        }
    }
}
