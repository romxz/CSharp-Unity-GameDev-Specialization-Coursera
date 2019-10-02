using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {
    // jump location support
    public float minX = -5.3f, maxX = 5.4f, minY = -3f, maxY = 3f;

    // timer support
    public float totalJumpDelaySeconds = 1f;
    private float elapsedJumpDelaySeconds = 0f;


    // Update is called once per frame
    void Update() {
        // update timer and check if it's done
        elapsedJumpDelaySeconds += Time.deltaTime;
        if (elapsedJumpDelaySeconds >= totalJumpDelaySeconds) {
            elapsedJumpDelaySeconds = 0f;
            transform.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0f);
        }
    }
}
