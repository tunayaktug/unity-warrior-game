using UnityEngine;

public class MetinTasiSpawner : MonoBehaviour
{
    public GameObject[] metinPrefabs; 
    public int spawnCount = 20;

    public float minRange = -500f;
    public float maxRange = 500f;

    void Start()
    {
        SpawnMetinTaslari();
    }

    void SpawnMetinTaslari()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            float randomX = Random.Range(minRange, maxRange);
            float randomZ = Random.Range(minRange, maxRange);
            float y = 1f; 

            Vector3 spawnPos = new Vector3(randomX, y, randomZ);

            int randomIndex = Random.Range(0, metinPrefabs.Length);
            GameObject prefab = metinPrefabs[randomIndex];

            Instantiate(prefab, spawnPos, Quaternion.identity);
        }
    }
}
