using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager {
    #region Fields
    // save lists of invokers and listeners
    static List<TeddyBear> invokers = new List<TeddyBear>();
    static List<UnityAction<int>> listeners = new List<UnityAction<int>>();
    #endregion

    #region Public Methods
    public static void AddInvoker(TeddyBear invoker) {
        invokers.Add(invoker);
        foreach (UnityAction<int> listener in listeners) {
            invoker.AddListener(listener);
        }
    }

    public static void AddListener(UnityAction<int> listener) {
        listeners.Add(listener);
        foreach (TeddyBear invoker in invokers) {
            invoker.AddListener(listener);
        }
    }
    #endregion
}
