using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDrop : MonoBehaviour
{
    public GameObject[] coinPrefabs;
    public int coinIndex;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    private float startDelay = 2f;

    private float spawnInterval = 1.5f;

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("SpawnRandomCoin", startDelay, spawnInterval);
    }

     void SpawnRandomCoin()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        int coinIndex = Random.Range(0,coinPrefabs.Length); //Picks random coin from array
        Instantiate(coinPrefabs[coinIndex],spawnPos,coinPrefabs[coinIndex].transform.rotation); //Spawns = idexed coin from radnom axis  
     }
}
   