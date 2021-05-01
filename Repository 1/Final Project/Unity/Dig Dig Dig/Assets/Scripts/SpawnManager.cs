using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pinkFlag;
    private float spawnRangeX = 15;
    private float spawnRangeZ = 15;
    private float startDelay = 3;
    private float spawnIntervalStart = 5;
    private float waveCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // waveCount * 5 = time to play
    // after time to play is up, broadcast game over!
}
