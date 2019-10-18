using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour {
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
    bool explodeInputOnPreviousFrame = false;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update() {
        // spawn teddy bear as appropriate
        if (Input.GetAxis("SpawnTeddyBear") > 0) {
            if (!spawnInputOnPreviousFrame) {
                // set flag to only capture first frame of axis activity
                spawnInputOnPreviousFrame = true;
                // spawn prefab at mouse location
                Vector3 position = Input.mousePosition;
                position.z = -Camera.main.transform.position.z;
                position = Camera.main.ScreenToWorldPoint(position);
                Instantiate<GameObject>(prefabTeddyBear, position, Quaternion.identity);
            }
        } else {
            spawnInputOnPreviousFrame = false;
        }
        // explode teddy bear as appropriate
        if (Input.GetAxis("ExplodeTeddyBear") > 0) {
            if (!explodeInputOnPreviousFrame) {
                // set flag to only capture first frame of axis activity
                explodeInputOnPreviousFrame = true;
                // find prefab to explode
                GameObject teddyBear = GameObject.FindWithTag("TeddyBear");
                if (teddyBear != null) {
                    Instantiate<GameObject>(prefabExplosion, teddyBear.transform.position, Quaternion.identity);
                    Destroy(teddyBear);
                }
            }
        } else {
            explodeInputOnPreviousFrame = false;
        }
    }
}
