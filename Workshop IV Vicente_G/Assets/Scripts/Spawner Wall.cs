using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class SpawnerWall : MonoBehaviour
{
    [SerializeField] private int obstacleCount = 11;
    [SerializeField] private GameObject wallPrefab;
    [SerializeField] private Vector2 minMaxXPos;

    private float zValue = 0f;
    private void Start()
    {
        for (int i = 0; i < obstacleCount; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minMaxXPos.x, minMaxXPos.y), 0.22f, zValue + 12);
            Instantiate(wallPrefab, spawnPos, Quaternion.identity);
            zValue += 10f;
        }

    }
}
