using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour // this is an example of a singleton pattern
{
    private TMP_Text text;
    private int score;
    public static ScoreText Instance { get; private set; }

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        Instance = this;
    }
    public void AddScore(int value)
    {
        score += value;
        text.SetText(score.ToString());
    }
}

