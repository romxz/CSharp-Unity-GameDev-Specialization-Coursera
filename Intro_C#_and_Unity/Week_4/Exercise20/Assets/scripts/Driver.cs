using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour {
    // move support
    const float MoveUnitsPerSecond = 6;

    // Update is called once per frame
    void Update() {
        // move horizontally and vertically
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (horizontalInput != 0 || verticalInput != 0) {
            Vector3 position = transform.position;
            position.x += horizontalInput * MoveUnitsPerSecond * Time.deltaTime;
            position.y += verticalInput * MoveUnitsPerSecond * Time.deltaTime;
            transform.position = position;
        }
    }
}
