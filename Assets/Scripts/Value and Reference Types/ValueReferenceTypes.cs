using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueReferenceTypes : MonoBehaviour
{
    private void Start()
    {
        MyTestClass first = new MyTestClass(7);
        MyTestClass second = first;
        second.value = 5;
        Debug.Log("Reference Type example: " + first.value);

        int a = 7;
        int b = a;
        b = 5;
        Debug.Log("Value Type example: " + a);
    }
}

public class MyTestClass
{
    public int value;

    public MyTestClass(int value)
    {
        this.value = value;
    }
}
