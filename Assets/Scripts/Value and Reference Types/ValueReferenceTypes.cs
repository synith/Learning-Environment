using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Burst;
using System;

public class ValueReferenceTypes : MonoBehaviour
{
    private void Start()
    {
        /*
        MyTestClass first = new MyTestClass(7);
        MyTestClass second = first;
        second.value = 5;
        Debug.Log("Class: " + first.value);

        MyTestStruct firstStruct = new MyTestStruct(7);
        MyTestStruct secondStruct = firstStruct;
        secondStruct.value = 5;
        Debug.Log("Struct: " + firstStruct.value);
        */
        /*
        NativeArray<MyTestStruct> testNativeArray = new NativeArray<MyTestStruct>(new MyTestStruct[] {
        new MyTestStruct(1),
        new MyTestStruct(2),
        new MyTestStruct(3)
        }, Allocator.TempJob);
        TestJob testJob = new TestJob { testNativeArray = testNativeArray };
        testJob.Run();

        for (int i = 0; i < testNativeArray.Length; i++)
        {
            Debug.Log(testNativeArray[i].value);
        }
        testNativeArray.Dispose();
        */
        /*
        int i = 5;
        Increment(ref i);
        Debug.Log(i);
        */

        int? i = null; // ? makes this a nullable value type
        Nullable<int> j = null; // using the ? is the same as using Nullable<T>

        WeaponTypes? playerHoldingWeaponType = null; // an example of how to set a weapon type enumerator to null if the player wasn't holding any weapons.
    }
    public enum WeaponTypes
    {
        Sword,
        Pistol,
    }

    public void Increment(ref int i)
    {
        i++;
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
public struct MyTestStruct
{
    public int value;
    public MyTestStruct(int value)
    {
        this.value = value;
    }
}

public struct TestJob : IJob
{
    public NativeArray<MyTestStruct> testNativeArray;
    public void Execute()
    {
        for (int i = 0; i < testNativeArray.Length; i++)
        {
            MyTestStruct myStruct = testNativeArray[i];
            myStruct.value++;
            testNativeArray[i] = myStruct;
        }
    }
}
