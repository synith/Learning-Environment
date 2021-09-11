using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingGenerics : MonoBehaviour
{
    private delegate void MyActionDelegate<T1, T2>(T1 t1, T2 t2);
    private Action<int, string> action;

    private delegate TResult MyFuncDelegate<T1, TResult>(T1 t1);
    private Func<int, bool>  func;

    private void Start()
    {
        CreateArray<int>(5, 6);

        TestMultiGenerics<int, string>(5, "6");

        MyClass<EnemyMinion> myClass = new MyClass<EnemyMinion>(new EnemyMinion());
        MyClass<EnemyArcher> myClassArcher = new MyClass<EnemyArcher>(new EnemyArcher());
         
    }

    private T[] CreateArray<T>(T firstElement, T secondElement)
    {
        return new T[] { firstElement, secondElement };
    }

    private void TestMultiGenerics<T1, T2>(T1 t1, T2 t2)
    {
        Debug.Log(t1.GetType());
        Debug.Log(t2.GetType());
    }
}

public class MyClass<T> where T : class, IEnemy<int>, new()
{
    public T value;

    public MyClass(T value)
    {
        value.Damage(0);
    }
    private T[] CreateArray(T firstElement, T secondElement)
    {
        return new T[] { firstElement, secondElement };
    }
}

public interface IEnemy<T>
{
    void Damage(T t);
}

public class EnemyMinion : IEnemy<int>
{
    public void Damage(int i)
    {
        Debug.Log("EnemyMinion.Damage()");
    }
}
public class EnemyArcher : IEnemy<int>
{
    public void Damage(int i)
    {
        Debug.Log("EnemyArcher.Damage()");
    }
}
