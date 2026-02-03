using System;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager Instance { get; private set; }

    public event Action OnMusicVolumeChanged;
    public event Action OnSoundVolumeChanged;

    private float musicVolume = 1f;
    private float soundVolume = 1f;

    public float MusicVolume
    {
        get => musicVolume;
        set
        {
            musicVolume = Mathf.Clamp01(value);
            OnMusicVolumeChanged?.Invoke();
        }
    }

    public float SoundVolume
    {
        get => soundVolume;
        set
        {
            soundVolume = Mathf.Clamp01(value);
            OnSoundVolumeChanged?.Invoke();
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
