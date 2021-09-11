using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEventSubscriber : MonoBehaviour
{
    private void Start()
    {
        TestEventPublisher testEventPublisher = GetComponent<TestEventPublisher>();
        testEventPublisher.OnSpacePressed += TestEventPublisher_OnSpacePressed;
        testEventPublisher.OnFloatEvent += TestEventPublisher_OnFloatEvent;
        testEventPublisher.OnActionEvent += TestEventPublisher_OnActionEvent;
    }

    private void TestEventPublisher_OnActionEvent(bool arg1, int arg2)
    {
        Debug.Log($"{arg1} {arg2}");
    }

    private void TestEventPublisher_OnFloatEvent(float f)
    {
        Debug.Log("Float: " + f);
    }

    private void TestEventPublisher_OnSpacePressed(object sender, TestEventPublisher.OnSpacePressedEventArgs e)
    {
        Debug.Log("Space! " + e.spaceCount);
    }

    public void TestingUnityEvent() 
    {
        Debug.Log("TestingUnityEvent");    
    }
}