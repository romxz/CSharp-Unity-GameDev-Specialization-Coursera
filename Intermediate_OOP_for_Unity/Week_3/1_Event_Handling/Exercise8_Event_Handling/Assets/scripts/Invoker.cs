using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An event invoker
/// </summary>
public class Invoker : MonoBehaviour {
    // no argument event support
    Timer timerNull;
    EventNull eventNull;

    // one argument event support
    Timer timerOne;
    EventOne eventOne;
    int count = 1;

    /// <summary>
    /// Awake is called before Start
    /// </summary>
    void Awake() {
        eventNull = new EventNull();
        eventOne = new EventOne();
    }

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start() {
        // no argument event
        timerNull = gameObject.AddComponent<Timer>();
        timerNull.Duration = 1;
        timerNull.Run();

        // one argument event
        timerOne = gameObject.AddComponent<Timer>();
        timerOne.Duration = 1;
        timerOne.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update() {
        // no argument event
        if (timerNull.Finished) {
            eventNull.Invoke();
            timerNull.Run();
        }

        // one argument event
        if (timerOne.Finished) {
            eventOne.Invoke(count);
            count++;
            timerOne.Run();
        }
    }

    /// <summary>
    /// Adds the given listener to the no argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddNoArgumentListener(UnityAction listener) {
        eventNull.AddListener(listener);
    }

    /// <summary>
    /// Adds the given listener to the one argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddOneArgumentListener(UnityAction<int> listener) {
        eventOne.AddListener(listener);
    }
}
