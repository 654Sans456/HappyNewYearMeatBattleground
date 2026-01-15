using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public GameObject[] healthObjects;
    public Sprite[] healthMainObjects = new Sprite[2];

    void Update()
    {
        for (int i = 0; i < maxHealth; i++)
        {
            SpriteRenderer spriteRenderer = healthObjects[i].GetComponent<SpriteRenderer>();

            if (i < health)
            {
                spriteRenderer.sprite = healthMainObjects[0];
            }
            else
            {
                spriteRenderer.sprite = healthMainObjects[1];
            }
        }
    }
}
