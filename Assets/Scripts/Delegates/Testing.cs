using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public delegate void TestDelegate();
    public delegate bool TestBoolDelegate(int i);

    private TestDelegate testDelegateFunction;
    private TestBoolDelegate testBoolDelegateFunction;

    private Action testAction;
    private Action<int, float> testIntFloatAction;
    private Func<bool> testFunc;
    private Func<int, bool> testIntBoolFunc;

    private void Start()
    {
        testDelegateFunction += () => { Debug.Log("Lambda Expression"); };
        testDelegateFunction += () => { Debug.Log("Second Lambda Expression"); };
        testDelegateFunction();

        testIntFloatAction = (int i, float f) => { Debug.Log("Test int float action: int="+ i + " float=" + f); };
        testIntFloatAction(3, 3.3333f);

        testFunc = () => false;
        Debug.Log(testFunc());

        testIntBoolFunc = (int i) => i > 10;
        Debug.Log(testIntBoolFunc(25));

        //testBoolDelegateFunction = (int i) => i < 5;
        //Debug.Log(testBoolDelegateFunction(6));

        //testBoolDelegateFunction = MyBoolTestDelegateFunction;
        //Debug.Log(testBoolDelegateFunction(4));
    }

    private void MyTestDelegateFunction()
    {
        Debug.Log("MyTestDelegateFunction");
    }

    private void MySecondTestDelegateFunction()
    {
        Debug.Log("MySecondTestDelegateFunction");
    }
    private bool MyBoolTestDelegateFunction(int i)
    {
        return i < 5;
    }
}
