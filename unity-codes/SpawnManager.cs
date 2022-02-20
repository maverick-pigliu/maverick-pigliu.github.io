using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spwanRangeX = 20;
    private float spwanRangeZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3 (Random.Range(-spwanRangeX,spwanRangeX),0,spwanRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

}
