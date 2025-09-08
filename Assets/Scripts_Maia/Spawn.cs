using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public List<GameObject> spawnPosition;
    public List<GameObject> obstaculosPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstaculos", 0, 1);
    }

    void SpawnObstaculos()
    {
        int randomSpawnPosition = Random.Range(0, spawnPosition.Count);
        int randomObstatucolsPrefab = Random.Range(0, obstaculosPrefab.Count);

        Instantiate(obstaculosPrefab[randomObstatucolsPrefab], spawnPosition[randomSpawnPosition].transform.position, Quaternion.identity);
    }
}
