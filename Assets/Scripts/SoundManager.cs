using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] OptionsSO optionsSO;

    [SerializeField] AudioClip buttonClip;
    [SerializeField] AudioClip pageClip;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        UpdateVolume();
    }


    public void PlayButtonSound()
    {
        audioSource.clip = buttonClip;
        audioSource.Play();
    }

    public void PlayPageSound()
    {
        audioSource.clip = pageClip;
        audioSource.Play();
    }

    public void UpdateVolume()
    {
        float volume = (float)optionsSO.SFXVolume/100f;
        audioSource.volume = volume;
    }
}


