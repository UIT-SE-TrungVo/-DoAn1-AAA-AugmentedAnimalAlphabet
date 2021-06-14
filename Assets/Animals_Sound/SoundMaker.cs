using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMaker : MonoBehaviour
{
    [SerializeField] AudioClip sound;
    [SerializeField] AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        Debug.Log("Source", source);
        source.playOnAwake = false;
        source.clip = sound;
    }

    public void PlaySound()
    {
        Debug.Log("Play sound", source.clip);
        source.Play();
    }

    public void EndSound()
    {
        Debug.Log("End sound");
        source.Stop();
    }
}
