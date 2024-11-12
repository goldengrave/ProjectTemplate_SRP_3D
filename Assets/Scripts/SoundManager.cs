using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource fxAudioSource, musicAudioSource;

    public AudioLibrary fxLibrary, musicLibrary;


    //Gets called before start, and regardless if the object is enabled
    void Awake()
    {
        if (instance == null)
            instance = this;

    }

    public void PlaySoundFX(string fileName)
    {
        foreach (AudioClip clip in fxLibrary.audioClips)
        {
            if (clip.name == fileName)
            {
                if (fxAudioSource.isPlaying)
                    fxAudioSource.Stop();

                fxAudioSource.PlayOneShot(clip);
            }
        }
    }

    public void PlayMusic(string fileName)
    {
        foreach (AudioClip clip in musicLibrary.audioClips)
        {
            if (clip.name == fileName)
            {
                if (musicAudioSource.isPlaying)
                    musicAudioSource.Stop();

                musicAudioSource.clip = clip;
                musicAudioSource.Play();
            }
        }
    }
}
