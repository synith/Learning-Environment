using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BubblePop : MonoBehaviour
{
    private Animator animator;
    private static readonly int Pop = Animator.StringToHash(name: "Pop");

    public static event Action OnAnyBubblePopped;

    private void Awake() => animator = GetComponent<Animator>();

    private void OnMouseDown()
    {
        animator.SetTrigger(id: Pop);
        ScoreText.Instance.AddScore(1);

        OnAnyBubblePopped?.Invoke();
    }

}