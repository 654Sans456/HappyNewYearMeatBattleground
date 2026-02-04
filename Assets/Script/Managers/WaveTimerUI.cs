using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveTimerUI : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    void Update()
    {
        if (WaveManager.Instance == null || !WaveManager.Instance.WaveActive)
            return;

        float timeLeft = WaveManager.Instance.TimeRemaining;
        int seconds = Mathf.CeilToInt(timeLeft);

        if (seconds <= 5)
            timerText.color = Color.red;
        else
            timerText.color = Color.white;


        timerText.text = "" + seconds;
    }
}
