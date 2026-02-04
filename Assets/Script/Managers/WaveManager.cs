using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class WaveManager : MonoBehaviour
{
    public static WaveManager Instance;

    public event Action<int> OnWaveStarted;
    public float TimeRemaining => Mathf.Max(0, waveDuration - timer);


    public int currentWave = 1;
    public float waveDuration = 40f;

    private float timer;
    public bool WaveActive { get; private set; }

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

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "GameMap")
        {
            StartWave();
        }
    }

    void Update()
    {
        if (!WaveActive) return;

        timer += Time.deltaTime;

        if (timer >= waveDuration)
        {
            EndWave();
        }
    }

    void StartWave()
    {
        timer = 0f;
        WaveActive = true;

        OnWaveStarted?.Invoke(currentWave);
    }

    void EndWave()
    {
        WaveActive = false;
        currentWave++;

        SceneManager.LoadScene("Menu");
    }
}
