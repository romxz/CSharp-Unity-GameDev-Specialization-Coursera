using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        EventManager.AddDestroyEventListener(DestroyAction);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddRelativeTorque(new Vector3(0, 0, 50));
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void DestroyAction() {
        Destroy(gameObject);
    }
}
