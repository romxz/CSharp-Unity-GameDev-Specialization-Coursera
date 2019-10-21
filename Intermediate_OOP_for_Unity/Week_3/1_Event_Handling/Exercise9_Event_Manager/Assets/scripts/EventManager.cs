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
    static Invoker noArgumentInvoker;
    static UnityAction noArgumentListener;

    // int argument event support
    static Invoker intArgumentInvoker;
    static UnityAction<int> intArgumentListener;

    /// <summary>
    /// Adds the invoker for the no argument event
    /// </summary>
    /// <param name="invoker">invoker</param>
    public static void AddNoArgumentInvoker(Invoker invoker)
    {
        noArgumentInvoker = invoker;
        if (noArgumentListener != null)
        {
            noArgumentInvoker.AddNoArgumentListener(noArgumentListener);
        }
    }

    /// <summary>
    /// Adds the listener for the no argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public static void AddNoArgumentListener(UnityAction listener)
    {
        noArgumentListener = listener;
        if (noArgumentInvoker != null)
        {
            noArgumentInvoker.AddNoArgumentListener(listener);
        }
    }

    /// <summary>
    /// Adds the invoker for the int argument event
    /// </summary>
    /// <param name="invoker">invoker</param>
    public static void AddIntArgumentInvoker(Invoker invoker)
    {
        intArgumentInvoker = invoker;
        if (intArgumentListener != null)
        {
            intArgumentInvoker.AddOneArgumentListener(intArgumentListener);
        }
    }

    /// <summary>
    /// Adds the listener for the int argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public static void AddIntArgumentListener(UnityAction<int> listener)
    {
        intArgumentListener = listener;
        if (intArgumentInvoker != null)
        {
            intArgumentInvoker.AddOneArgumentListener(listener);
        }
    }
}
