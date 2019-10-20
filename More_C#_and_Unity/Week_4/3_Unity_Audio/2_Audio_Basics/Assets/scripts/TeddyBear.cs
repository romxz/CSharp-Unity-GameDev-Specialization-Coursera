using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour {
    // audio support
    AudioSource audioSource;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Play sound when mouse enters collider
    /// </summary>
    void OnMouseEnter() {
        audioSource.Play();
    }
}
