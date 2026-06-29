using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    public static int candleCount = 0;
    [SerializeField] GameObject candleDisplay;

    private void Update()
    {
        candleDisplay.GetComponent<TMPro.TMP_Text>().text = "Candles: " + candleCount;
    }


}
