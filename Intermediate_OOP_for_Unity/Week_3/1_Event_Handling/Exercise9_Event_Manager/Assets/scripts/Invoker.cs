using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An event invoker
/// </summary>
public class Invoker : MonoBehaviour {
    // no argument event support
    Timer messageTimer;
    MessageEvent messageEvent;

    // one argument event support
    Timer countMessageTimer;
    CountMessageEvent countMessageEvent;
    int count = 1;

    /// <summary>
    /// Awake is called before Start
    /// </summary>
    void Awake() {
        messageEvent = new MessageEvent();
        countMessageEvent = new CountMessageEvent();
    }

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start() {
        // no argument event
        EventManager.AddNoArgumentInvoker(this);
        messageTimer = gameObject.AddComponent<Timer>();
        messageTimer.Duration = 1;
        messageTimer.Run();

        // one argument event
        EventManager.AddIntArgumentInvoker(this);
        countMessageTimer = gameObject.AddComponent<Timer>();
        countMessageTimer.Duration = 1;
        countMessageTimer.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update() {
        // no argument event
        if (messageTimer.Finished) {
            messageEvent.Invoke();
            messageTimer.Run();
        }

        // one argument event
        if (countMessageTimer.Finished) {
            countMessageEvent.Invoke(count);
            count++;
            countMessageTimer.Run();
        }
    }

    /// <summary>
    /// Adds the given listener to the no argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddNoArgumentListener(UnityAction listener) {
        messageEvent.AddListener(listener);
    }

    /// <summary>
    /// Adds the given listener to the one argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddOneArgumentListener(UnityAction<int> listener) {
        countMessageEvent.AddListener(listener);
    }
}
