using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Shrink and grow the game object over time
/// </summary>
public class Resizer : MonoBehaviour {
    // for timer support
    public float totalResizeSeconds = 1f;
    private float elapsedResizeSeconds = 0f;

    // for resizing control
    public float scaleFactorPerSecond = 1f;
    private int scaleFactorSignMultiplier = 1;

    // Update is called once per frame
    void Update() {
        
        float timeDelta = Time.deltaTime;
        Vector3 newScale = this.gameObject.transform.localScale;
        newScale.x += scaleFactorPerSecond * scaleFactorSignMultiplier * timeDelta;
        newScale.y += scaleFactorPerSecond * scaleFactorSignMultiplier * timeDelta;
        this.gameObject.transform.localScale = newScale;

        elapsedResizeSeconds += timeDelta;
        if (elapsedResizeSeconds >= totalResizeSeconds) {
            scaleFactorSignMultiplier *= -1;
            elapsedResizeSeconds = 0f;
        }
        
    }
}
