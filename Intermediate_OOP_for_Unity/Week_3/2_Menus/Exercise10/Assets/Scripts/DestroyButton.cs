using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyButton : MonoBehaviour {
    DestroyEvent destroyEvent = new DestroyEvent();

    // Start is called before the first frame update
    void Start() {
        EventManager.AddDestroyEventInvoker(this);
    }

    // Update is called once per frame
    void Update() {

    }

    public void AddDestroyEventListener(UnityAction listener) {
        destroyEvent.AddListener(listener);
    }

    public void HandleDestroyEvent() {
        destroyEvent.Invoke();
    }
}
