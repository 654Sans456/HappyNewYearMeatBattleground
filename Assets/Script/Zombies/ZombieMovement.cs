using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class ZombieMovement : MonoBehaviour
{
    public float speed = 2f;

    private Transform target;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        target = GameObject.FindWithTag("Player").transform;

        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            direction.Normalize();

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

            movement = direction;
        }
    }

    void FixedUpdate()
    {
        MoveZombie(movement);
    }

    void MoveZombie(Vector2 direction)
    {
        rb.MovePosition(rb.position + (direction * speed * Time.fixedDeltaTime));
    }
}
