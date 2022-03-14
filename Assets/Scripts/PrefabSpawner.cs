using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _FemaleDummy;

    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToClonePrefab;

    void Start()
    {
        spawnSomething(0, 0, 0);
        spawnSomething(1, 1, 1);
        spawnSomething(2, 2, 2);
    }

    
    void Update()
    {
    
    }

    void spawnSomething(int clone, int spawn, int location)
    {
        whatToClonePrefab[clone] = Instantiate(
            whatToSpawnPrefab[spawn], 
            spawnLocations[location].transform.position, 
            Quaternion.Euler(0, 90, 0)) 
            as GameObject;
    }
}
