using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] private float smoothSpd = 1f;
    private Vector3 offset;

    private void Awake()
    {
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, target.position.x, smoothSpd), transform.position.y, target.position.z + offset.z);
    }
}
