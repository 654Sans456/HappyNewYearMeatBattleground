using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        ApplyVolume();
    }

    private void OnEnable()
    {
        if (SettingsManager.Instance != null)
            SettingsManager.Instance.OnMusicVolumeChanged += ApplyVolume;
    }

    private void OnDisable()
    {
        if (SettingsManager.Instance != null)
            SettingsManager.Instance.OnMusicVolumeChanged -= ApplyVolume;
    }

    public void ApplyVolume()
    {
        if (SettingsManager.Instance != null)
            audioSource.volume = SettingsManager.Instance.MusicVolume;
    }
}
