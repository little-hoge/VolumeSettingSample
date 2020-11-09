﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour {
    public enum VolumeType { MASTER, BGM, SE }

    [SerializeField]
    VolumeType volumeType = 0;

    Slider slider;
    SoundManager soundManager;

    void Start() {
        slider = GetComponent<Slider>();
        soundManager = FindObjectOfType<SoundManager>();

        switch (volumeType) {
            case VolumeType.MASTER:
                 slider.value= soundManager.Volume;
                break;
            case VolumeType.BGM:
                slider.value = soundManager.BgmVolume;
                break;
            case VolumeType.SE:
                slider.value = soundManager.SeVolume;
                break;
        }
    }

    public void OnValueChanged() {

        switch (volumeType) {
            case VolumeType.MASTER:
                if(soundManager.Volume != slider.value)SoundManager.Instance.PlayBgm(0);
                soundManager.Volume = slider.value;               
                break;
            case VolumeType.BGM:
                if (soundManager.BgmVolume != slider.value) SoundManager.Instance.PlayBgm(0);
                soundManager.BgmVolume = slider.value;
                break;
            case VolumeType.SE:
                if (soundManager.SeVolume != slider.value) SoundManager.Instance.PlaySe(0);
                soundManager.SeVolume = slider.value;
                break;
        }
    }
}