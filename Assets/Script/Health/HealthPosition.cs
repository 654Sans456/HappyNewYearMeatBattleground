using UnityEngine;

public class HealthPosition : MonoBehaviour
{
    public Camera camera;
    public Transform target;

    public Vector2 offset;

    void FixedUpdate()
    {
        if (target != null)
        {
            transform.rotation = camera.transform.rotation;
            transform.position = target.position + (Vector3)offset;
        }
    }
}
