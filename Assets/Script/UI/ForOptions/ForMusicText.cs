using TMPro;
using UnityEngine;

public class ForMusicText : MonoBehaviour
{
    private TMP_Text textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TMP_Text>();
    }

    void Update()
    {
        int PercentMusicVolume = (int)(SettingsManager.Instance.MusicVolume * 100);
        textMeshPro.text = "Music: " + (((PercentMusicVolume % 10) == 9) ? 
                                        (PercentMusicVolume + 1) :
                                        (PercentMusicVolume));
    }
}
