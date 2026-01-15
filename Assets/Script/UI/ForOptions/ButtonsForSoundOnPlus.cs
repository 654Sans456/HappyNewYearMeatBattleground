using UnityEngine;

public class ButtonsForSoundOnPlus : MonoBehaviour
{
    public AudioSource soundSource;

    private void Start()
    {
        soundSource.volume = SettingsManager.Instance.SoundVolume;
    }

    public void IncreaseVolume()
    {
        SettingsManager.Instance.SoundVolume += 0.1f;
        soundSource.volume = SettingsManager.Instance.SoundVolume;
        soundSource.PlayOneShot(soundSource.clip);
    }
}
