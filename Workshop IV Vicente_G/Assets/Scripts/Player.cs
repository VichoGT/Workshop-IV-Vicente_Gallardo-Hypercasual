using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] Joystick joystick;

    [SerializeField] public float forwardSpd;
    [SerializeField] private float leftRightSpd;
    [SerializeField] private Vector2 minMaxX;

    private float originalForwardSpd; 
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        originalForwardSpd = forwardSpd; 
    }

    private void Start()
    {
        transform.DOScaleY(0, 8);
    }

    [System.Obsolete]
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minMaxX.x, minMaxX.y), 0, transform.position.z);
        rb.velocity = new Vector3(joystick.Horizontal * leftRightSpd * Time.deltaTime, rb.velocity.y, forwardSpd * Time.deltaTime);

        if (transform.localScale.y <= 0.1f)
        {
            DOTween.Kill(transform);
            Debug.Log("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SmallCandle"))
        {
            Destroy(other.gameObject);
            DOTween.Kill(transform);
            transform.DOScaleY(1.2f, 1).OnComplete(() => {
            
                transform.DOScaleY(0, 8);
            });
        }
        //  BOOST PAD
        if (other.gameObject.CompareTag("BoostPad"))
        {
            StartCoroutine(ApplySpeedBoost(1.75f, 1f));
            // 1.75x velocidad durante 1 segundos
        }

    }
    private IEnumerator ApplySpeedBoost(float multiplier, float duration)
    {
        forwardSpd *= multiplier;
        yield return new WaitForSeconds(duration);
        forwardSpd = originalForwardSpd;
    }
}
