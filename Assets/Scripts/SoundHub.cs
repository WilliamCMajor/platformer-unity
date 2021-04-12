using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHub : MonoBehaviour
{
    AudioSource[] sources;
    private void Awake()
    {
        sources = GetComponents<AudioSource>();
    }
    public void PlayCoinSound()
    {  
        sources[0].Play();
    }
}
