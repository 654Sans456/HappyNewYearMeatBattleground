using TMPro;
using UnityEngine;

public class ForSoundText : MonoBehaviour
{
    private TMP_Text textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TMP_Text>();
    }

    void Update()
    {
        int PercentSoundVolume = (int)(SettingsManager.Instance.SoundVolume * 100);
        textMeshPro.text = "Sound: " + (((PercentSoundVolume % 10) == 9) ?
                                        (PercentSoundVolume + 1) :
                                        (PercentSoundVolume));
    }
}
