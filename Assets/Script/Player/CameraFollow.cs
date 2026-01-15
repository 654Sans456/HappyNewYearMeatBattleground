using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float followRadius = 0f;
    public float minSmoothSpeed = 0f;
    public float maxSmoothSpeed = 1f;

    public Vector2 offset = new Vector2(0f, 0f);

    private Transform player;

    void LateUpdate()
    {
        player = GameObject.FindWithTag("Player").transform;

        if (player != null)
        {
            Vector3 playerPosition = new Vector3(player.position.x, player.position.y, transform.position.z);
            float distance = Vector2.Distance(new Vector2(transform.position.x, transform.position.y), new Vector2(player.position.x, player.position.y));

            if (distance > followRadius)
            {
                transform.position = Vector3.Lerp(transform.position, playerPosition, (maxSmoothSpeed / 100));
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, playerPosition, (minSmoothSpeed / 100));
            }
        }
    }
}
