using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestEventPublisher : MonoBehaviour
{
    public event EventHandler<OnSpacePressedEventArgs> OnSpacePressed;

    public class OnSpacePressedEventArgs : EventArgs
    {
        public int spaceCount;
    }

    public event TestEventDelegate OnFloatEvent;
    public delegate void TestEventDelegate(float f);

    public event Action<bool, int> OnActionEvent;

    public UnityEvent OnUnityEvent;
    private int spaceCount;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Space Pressed!
            spaceCount++;
            OnSpacePressed?.Invoke(this, new OnSpacePressedEventArgs { spaceCount = spaceCount });

            OnFloatEvent?.Invoke(5.5f);

            OnActionEvent?.Invoke(true, 42);

            OnUnityEvent?.Invoke();
        }
    }
}