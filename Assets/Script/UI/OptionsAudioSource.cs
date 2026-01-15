using UnityEngine;

public class OptionsAudioSource : MonoBehaviour
{
    public bool isMusic;
    public AudioSource soundSource;

    void Start()
    {
        if (isMusic)
        {
            soundSource.volume = SettingsManager.Instance.MusicVolume;
        }
        else
        {
            soundSource.volume = SettingsManager.Instance.SoundVolume;
        }
    }
}
