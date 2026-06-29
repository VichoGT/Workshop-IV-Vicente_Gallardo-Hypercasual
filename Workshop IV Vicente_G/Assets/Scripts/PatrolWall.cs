using UnityEngine;

public class PatrolWall : MonoBehaviour
{
    public Rigidbody rb2;
    public float speed = 5f;

    void Start()
    {
        rb2.GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb2.linearVelocity = Vector3.right * speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            speed *= -1f;
        }
    }
}
