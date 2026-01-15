using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject healthPlayer;

    private GameObject[] positionZombies;

    void Update()
    {
        positionZombies = GameObject.FindGameObjectsWithTag("Zombie");

        foreach (GameObject positionZombie in positionZombies)
        {
            float distance = Vector3.Distance(transform.position, positionZombie.transform.position);

            if (distance < 1.3)
            {
                Destroy(positionZombie.gameObject);

                healthPlayer.GetComponent<HealthSystem>().health--;
            }
        }

        if (healthPlayer.GetComponent<HealthSystem>().health <= 0)
        {
            GameManager.Instance.NameScenes = "ReturnGame";
            SceneManager.LoadScene("Loading");
        }
    }
}
