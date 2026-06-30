using UnityEngine;

public class RotateCollectable : MonoBehaviour
{
    [SerializeField] int rotateSpd = 1;



    private void Update()
    {
        transform.Rotate(0, rotateSpd, 0, Space.World);
    }
}
