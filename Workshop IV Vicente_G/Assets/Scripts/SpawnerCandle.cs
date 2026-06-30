using UnityEngine;

public class SpawnerCandle : MonoBehaviour
{
    [SerializeField] private int candleCount = 11;
    [SerializeField] private GameObject smallCandlePrefab;
    [SerializeField] private Vector2 minMaxXPos;

    private float zValue = 0f;
    private void Start()
    {
        for (int i = 0; i < candleCount; i++) 
        {
            Vector3 spawnPos = new Vector3 (Random.Range(minMaxXPos.x,minMaxXPos.y), 0, zValue + 8);
            Instantiate(smallCandlePrefab, spawnPos, Quaternion.identity);
            zValue += 10f; 
        }
      
    }

}
