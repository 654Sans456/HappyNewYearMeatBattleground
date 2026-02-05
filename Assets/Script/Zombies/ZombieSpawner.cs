using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;

    public float spawnRadius = 10f;
    public float spawnInterval = 2f;

    private Transform player;

    private float timer;

    void Update()
    {
        if (WaveManager.Instance == null || !WaveManager.WaveActive)
            return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnZombie();
            timer = 0f;
        }
    }

    Vector2 GetRandomSpawnPosition()
    {
        float angle = Random.Range(0f, 360f) * Mathf.Deg2Rad;

        float x = player.position.x + (Mathf.Cos(angle) * spawnRadius), y = player.position.y + (Mathf.Sin(angle) * spawnRadius);

        return new Vector2(x, y);
    }

    void SpawnZombie()
    {
        if (player == null)
        {
            GameObject p = GameObject.FindWithTag("Player");
            if (p != null) player = p.transform;
            else return;
        }

        Vector2 spawnPosition = GetRandomSpawnPosition();
        Instantiate(zombiePrefab, spawnPosition, Quaternion.identity);
    }
}
