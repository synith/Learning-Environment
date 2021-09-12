using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopAudioPlayer : MonoBehaviour // This is an example of the Observer Pattern
{
    private AudioSource audioSource;

    private void Awake() => audioSource = GetComponent<AudioSource>();
    private void OnEnable() => BubblePop.OnAnyBubblePopped += PlayPopAudio;
    private void OnDisable() => BubblePop.OnAnyBubblePopped -= PlayPopAudio;
    private void PlayPopAudio() => audioSource.Play();
}
