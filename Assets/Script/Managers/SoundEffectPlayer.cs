using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
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

    public void ApplyVolume()
    {
        if (SettingsManager.Instance != null)
            audioSource.volume = SettingsManager.Instance.SoundVolume;
    }
}
