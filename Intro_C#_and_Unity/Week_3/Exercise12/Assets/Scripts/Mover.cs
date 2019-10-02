using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        // get the game object moving
        this.GetComponent<Rigidbody2D>().AddForce(
            new Vector2(0, 5), ForceMode2D.Impulse);
    }

}
