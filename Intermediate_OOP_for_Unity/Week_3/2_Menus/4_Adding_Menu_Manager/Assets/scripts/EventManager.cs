using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An event manager
/// </summary>
public static class EventManager 
{
    static Fish invoker;
    static UnityAction<int> listener;

    /// <summary>
    /// Adds the invoker
    /// </summary>
    /// <param name="script">fish script</param>
    public static void AddInvoker(Fish script)
    {
        invoker = script;
        if (listener != null)
        {
            invoker.AddPointsAddedEventListener(listener);
        }
    }

    /// <summary>
    /// Adds the listener
    /// </summary>
    /// <param name="handler">event handler</param>
    public static void AddListener(UnityAction<int> handler)
    {
        listener = handler;
        if (invoker != null)
        {
            invoker.AddPointsAddedEventListener(listener);            
        }
    }
}
