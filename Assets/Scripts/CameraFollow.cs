using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    void LateUpdate()
    {
        Vector3 newPos = new Vector3(transform.position.x, target.position.y, -10f);
        if (target.position.y > transform.position.y)
        {
            transform.position = newPos;
        }
    }
}