using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager {
    static Fish invoker;
    static UnityAction<int> listener;

    /// <summary>
    /// Adds the invoker
    /// </summary>
    /// <param name="script"></param>
    public static void AddInvoker(Fish script) {
        invoker = script;
        if (listener != null) {
            invoker.AddPointsAddedEventListener(listener);
        }
    }

    public static void AddListener(UnityAction<int> handler) {
        listener = handler;
        if (invoker != null) {
            invoker.AddPointsAddedEventListener(listener);
        }
    }
}
