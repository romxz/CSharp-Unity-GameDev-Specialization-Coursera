using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTeddyBear : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        // quadruple width and height
        Vector3 newScale = transform.localScale;

        newScale.x *= 4;
        newScale.y *= 4;
        transform.localScale = newScale;
    }

}
