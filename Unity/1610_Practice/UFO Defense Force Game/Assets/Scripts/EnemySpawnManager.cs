using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //Array to store UFO ships
    public int ufoIndex;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        int ufoIndex = Random.Range(0,ufoPrefabs.Length); //Picks random UFO from array
        Instantiate(ufoPrefabs[ufoIndex],spawnPos,ufoPrefabs[ufoIndex].transform.rotation); //Spawns = idexed UFO from radnom axis
        }
    }
}
