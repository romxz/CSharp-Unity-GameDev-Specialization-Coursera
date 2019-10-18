using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {
    // Update is called once per frame
    void Update() {
        // if mouse is left clicked, move the object to where the mouse is
        if (Input.GetMouseButtonDown(0)) {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            transform.position = Camera.main.ScreenToWorldPoint(position);
        }
    }
}
