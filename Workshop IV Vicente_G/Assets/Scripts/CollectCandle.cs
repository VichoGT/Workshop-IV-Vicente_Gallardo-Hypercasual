using UnityEngine;

public class CollectCandle : MonoBehaviour
{
    [SerializeField] AudioSource candleFX;


    private void OnTriggerEnter(Collider other)
    {
        candleFX.Play();
        MasterInfo.candleCount += 1;
        this.gameObject.SetActive(false);
    }
}
