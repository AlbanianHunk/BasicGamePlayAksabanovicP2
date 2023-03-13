using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    int sideMinZ = 2;
    int sideMaxZ = 15;
    int spawnPosX = 15;
    int spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal()
    {
       // Spawn top
        SpawnRandomAnimal(new Vector3(-Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ), Quaternion.Euler(0, 180, 0));

        // Spawn left side
        SpawnRandomAnimal(new Vector3(-spawnPosX - 5, 0, Random.Range(sideMinZ, sideMaxZ)), Quaternion.Euler(0, 90, 0));

        // Spawn right side
        SpawnRandomAnimal(new Vector3(spawnPosX + 5, 0, Random.Range(sideMinZ, sideMaxZ)), Quaternion.Euler(0, -90, 0));
    }

    void SpawnRandomAnimal(Vector3 spawnPos, Quaternion rotation)
    {
        Instantiate(animalPrefabs[Random.Range(0, animalPrefabs.Length)], spawnPos, rotation);
    }
}
