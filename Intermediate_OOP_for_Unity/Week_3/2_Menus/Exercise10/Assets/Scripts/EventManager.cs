using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager {
    static DestroyButton destroyEventInvoker;
    static UnityAction destroyEventListener;

    public static void AddDestroyEventInvoker(DestroyButton invoker) {
        destroyEventInvoker = invoker;
        if (destroyEventListener != null) destroyEventInvoker.AddDestroyEventListener(destroyEventListener);
    }

    public static void AddDestroyEventListener(UnityAction listener) {
        destroyEventListener = listener;
        if (destroyEventInvoker != null) destroyEventInvoker.AddDestroyEventListener(destroyEventListener);
    }
}
