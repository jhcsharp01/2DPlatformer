using UnityEngine;

public class FollowingCamera : MonoBehaviour
{

    public Transform target;
    public float speed = 5.0f;
    public Vector2 offset;
    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 position = new Vector3(target.position.x, target.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
    }
}
