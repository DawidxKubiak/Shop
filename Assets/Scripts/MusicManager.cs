using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] OptionsSO optionsSO;

    AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        UpdateVolume();
    }

    public void UpdateVolume()
    {
        float volume = (float)optionsSO.musicVolume / 100f;
        audioSource.volume = volume;
    }
}
