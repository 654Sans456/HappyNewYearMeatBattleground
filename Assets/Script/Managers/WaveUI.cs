using TMPro;
using UnityEngine;

public class WaveUI : MonoBehaviour
{
    public TextMeshProUGUI waveText;

    void Start()
    {
        if (WaveManager.Instance != null)
        {
            WaveManager.Instance.OnWaveStarted += UpdateWaveText;

            UpdateWaveText(WaveManager.Instance.currentWave);
        }
    }

    void OnDestroy()
    {
        if (WaveManager.Instance != null)
            WaveManager.Instance.OnWaveStarted -= UpdateWaveText;
    }

    void UpdateWaveText(int waveNumber)
    {
        waveText.text = "Wave: " + waveNumber;
    }
}