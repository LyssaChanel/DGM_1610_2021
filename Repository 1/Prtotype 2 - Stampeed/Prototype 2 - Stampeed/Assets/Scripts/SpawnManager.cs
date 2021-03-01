using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //randomly generate animals on x axis
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnRangeZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        if(Input.GetKeyDown(KeyCode.S)){
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
