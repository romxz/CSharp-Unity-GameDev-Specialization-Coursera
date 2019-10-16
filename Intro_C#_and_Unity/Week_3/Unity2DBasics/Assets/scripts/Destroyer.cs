using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
    [SerializeField]
    GameObject prefabExplosion;

    // timer support
    Timer explodeTimer;

    // Start is called before the first frame update
    void Start() {
        explodeTimer = gameObject.AddComponent<Timer>();
        explodeTimer.Duration = 1;
        explodeTimer.Run();
    }

    // Update is called once per frame
    void Update() {
        // find and blow up a C4 Teddy Bear
        if (explodeTimer.Finished) {
            explodeTimer.Run();

            GameObject teddyBear = GameObject.FindWithTag("C4TeddyBear");
            if (teddyBear != null) {
                Instantiate<GameObject>(prefabExplosion,
                    teddyBear.transform.position, Quaternion.identity);
                Destroy(teddyBear);
            }
        }
        
    }
}
