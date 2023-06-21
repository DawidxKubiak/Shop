using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    [SerializeField] OptionsSO optionsSO;

    [SerializeField] TextMeshProUGUI FullScreenButton;

    [SerializeField] Slider musicSlider;

    [SerializeField] Slider SFXSlider;

    bool isFullScreen = true;

    public void FullScreen()
    {
        isFullScreen = !isFullScreen;

        if (isFullScreen)
        {
            FullScreenButton.text = "X";
            Screen.fullScreen = true;
        }
        else
        {
            FullScreenButton.text = "";
            Screen.fullScreen = false;
        }
    }

    public void ChangeMusicVolume()
    {
        optionsSO.musicVolume = (int)musicSlider.value;
    }

    public void ChangeSFXVolume()
    {
        optionsSO.SFXVolume = (int)SFXSlider.value;
    }
}
