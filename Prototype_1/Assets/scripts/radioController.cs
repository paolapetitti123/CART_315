using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioController : MonoBehaviour
{
    private AudioSource playerAudioSource;

    private void Start()
    {
        playerAudioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        playerAudioSource.Play();
    }

    public void PauseAudio()
    {
        playerAudioSource.Pause();
    }

    public void StopAudio()
    {
        playerAudioSource.Stop();
    }
}
