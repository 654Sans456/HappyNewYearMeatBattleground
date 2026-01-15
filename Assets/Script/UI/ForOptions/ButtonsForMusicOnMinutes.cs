using UnityEngine;

public class ButtonsForMusicOnMinutes : MonoBehaviour
{
    public AudioSource soundSource;

    private void Start()
    {
        soundSource.volume = SettingsManager.Instance.MusicVolume;
    }

    public void IncreaseVolume()
    {
        SettingsManager.Instance.MusicVolume -= 0.1f;
        soundSource.volume = SettingsManager.Instance.MusicVolume;
        soundSource.PlayOneShot(soundSource.clip);
    }
}
