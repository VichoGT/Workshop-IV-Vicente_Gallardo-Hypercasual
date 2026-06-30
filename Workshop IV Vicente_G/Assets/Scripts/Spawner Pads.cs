using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class SpawnerPads : MonoBehaviour
{
    [SerializeField] private int padPrefabCount = 11;
    [SerializeField] private GameObject padPrefab;
    [SerializeField] private Vector2 minMaxXPos;

    private float zValue = 0f;

    private void Start()
    {
        for (int i = 0; i < padPrefabCount; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minMaxXPos.x, minMaxXPos.y), -0.155f, zValue + 10);
           
            Quaternion rotation = Quaternion.Euler(0, 90, 0);

            Instantiate(padPrefab, spawnPos, rotation);

            zValue += 10f;
        }
    }
}
