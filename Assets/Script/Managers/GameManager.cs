using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public static int Scores=0;
    private string nameScenes = "";
    private int score = 0;
    private int coins = 0;

    public string NameScenes
    {
        get => nameScenes;
        set => nameScenes = value;
    }

    public int Score
    {
        get => score;
        set => score = Mathf.Max(0, value);
    }

    public int Coins
    {
        get => coins;
        set => coins = Mathf.Max(0, value);
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
