using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTimer : MonoBehaviour
{
    [SerializeField] private ActionOnTimer actionOnTimer;    
    private void Start()
    {
        actionOnTimer.SetTimer(1f, () => { Debug.Log("Timer complete!"); });
    }    
}
