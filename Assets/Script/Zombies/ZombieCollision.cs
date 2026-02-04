using UnityEngine;

public class ZombieCollision : MonoBehaviour
{
    public GameObject healthZombie;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);

            healthZombie.GetComponent<HealthSystem>().health-=PlayerController.attack;
            GameManager.Instance.Score++;
        }

        if (healthZombie.GetComponent<HealthSystem>().health <= 0)
        {
            Destroy(gameObject);
            GameManager.Instance.Score += 5;
        }
    }
}
