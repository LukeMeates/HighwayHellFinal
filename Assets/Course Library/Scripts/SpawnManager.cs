using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] vehiclePrefabs;
    public int vehicleIndex;
    private float spawnRangeX = 20;
    private float spawnPosZ = 325;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVehicle", 1, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnVehicle()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(vehiclePrefabs[vehicleIndex], spawnPos, vehiclePrefabs[vehicleIndex].transform.rotation);
    }
}
