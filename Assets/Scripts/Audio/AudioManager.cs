using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip mainMenuMusic;
    public AudioClip buttonSelectSound;
    public AudioClip buttonSelectSound1;
    public AudioClip buttonSelectSound2;
    public AudioClip buttonSelectSound3;
    public AudioClip buttonSelectSound4;
    public AudioClip buttonSelectSound5;

    public AudioSource musicAudioSource;
    public AudioSource sfxAudioSource;

    void Start()
    {
        musicAudioSource.loop = true;
        PlayBackgroundSound(mainMenuMusic);
    }

    //Use this function to play sound effects
    public void PlaySFX()
    {
        Debug.Log("Plays button or sfx sounds from here");
        sfxAudioSource.clip = buttonSelectSound;
        sfxAudioSource.Play();
    }

    //Play this function to play background music
    public void PlayBackgroundSound(AudioClip audioClip)
    {
        Debug.Log("Plays background music from here");
        musicAudioSource.clip = audioClip;
        musicAudioSource.Play();
    }

}
