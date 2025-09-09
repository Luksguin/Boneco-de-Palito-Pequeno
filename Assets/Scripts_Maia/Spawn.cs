using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float time;

    public List<GameObject> spawnPosition;
    public List<GameObject> obstaculosPrefab;

    void Start()
    {
        InvokeRepeating("SpawnObstaculos", 0, time);
    }

    void SpawnObstaculos()
    {
        int randomSpawnPosition = Random.Range(0, spawnPosition.Count);
        int randomObstatucolsPrefab = Random.Range(0, obstaculosPrefab.Count);

        Instantiate(obstaculosPrefab[randomObstatucolsPrefab], spawnPosition[randomSpawnPosition].transform.position, Quaternion.identity);
    }
}
