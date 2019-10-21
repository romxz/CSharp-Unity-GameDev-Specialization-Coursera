using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// The event manager
/// </summary>
public static class EventManager
{
    // no argument event support
    static DestroyButton destroyEventInvoker;
    static UnityAction destroyEventListener;

    /// <summary>
    /// Adds the invoker for the destroy event
    /// </summary>
    /// <param name="invoker">invoker</param>
    public static void AddDestroyEventInvoker(DestroyButton invoker)
    {
        destroyEventInvoker = invoker;
        if (destroyEventListener != null)
        {
            destroyEventInvoker.AddDestroyEventListener(destroyEventListener);
        }
    }

    /// <summary>
    /// Adds the listener for the destroy event
    /// </summary>
    /// <param name="listener">listener</param>
    public static void AddDestroyEventListener(UnityAction listener)
    {
        destroyEventListener = listener;
        if (destroyEventInvoker != null)
        {
            destroyEventInvoker.AddDestroyEventListener(listener);
        }
    }
}
