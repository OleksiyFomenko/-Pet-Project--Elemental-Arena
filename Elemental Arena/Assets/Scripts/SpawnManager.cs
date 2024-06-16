using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyBoss;

    private float spawnRange = 10;
    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnamyWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnamyWave(waveNumber);
        }
    }
    void SpawnEnamyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn * PlayerInfo.level; i++)
        {            
                Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
        if (enemiesToSpawn % 5f == 0)
        {
            Instantiate(enemyBoss, GenerateSpawnPosition(), enemyBoss.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, -4, spawnPosZ);
        return randomPos;
    }
}
