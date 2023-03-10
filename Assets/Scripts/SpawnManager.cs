using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour{

    public GameObject[]animalPrefabs;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;
    private float spawnRangeX = 20;
    private float spawnPosZ = 30;
    private float startDelayTop = 2;
    private float startDelayLeft = 1;
    private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start(){
        InvokeRepeating("SpawnRandomAnimal", startDelayTop, spawnInterval); 
        InvokeRepeating("SpawnLeftAnimal", startDelayLeft, spawnInterval);
    }

    // Update is called once per frame
    void Update(){

    }

    // Randomly generate animal index and spawn position on the top of the screen
    void SpawnRandomAnimal(){
        Vector3 spawnPosForward = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosForward,
        animalPrefabs[animalIndex].transform.rotation); 
    } 

    // Randomly generate animal index and spawn position on the left of the screen
        void SpawnLeftAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ,
        sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}

