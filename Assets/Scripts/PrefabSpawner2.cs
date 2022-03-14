using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner2 : MonoBehaviour
{

    [SerializeField] public GameObject _FemaleDummy;
    [SerializeField] public GameObject _MaleDummy;

    public Vector3[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToClonePrefab;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocations = new Vector3[3];
        whatToSpawnPrefab = new GameObject[3];
        whatToClonePrefab = new GameObject[3];

        _FemaleDummy = GameObject.Find("FemaleDummy");
        _MaleDummy = GameObject.Find("MaleDummy");

        /*
         * Populate whatToSpawnPrefab and whatToClonePrefab arraylists
         */
        bool gender = true;
        for(int x = 0; x < 3; x++)
        {

            if (gender)
            {
                whatToSpawnPrefab[x] = _FemaleDummy;
                whatToClonePrefab[x] = _FemaleDummy;
            }
            else
            {
                whatToSpawnPrefab[x] = _MaleDummy;
                whatToClonePrefab[x] = _MaleDummy;
            }

            gender = !gender;
        }

        spawnLocations[0] = new Vector3(-3, 3, 3);
        spawnLocations[1]= new Vector3(-3, 3, 0);
        spawnLocations[2] = new Vector3(-3, 3, -3);

        spawnSomething(0, 0, 0);
        spawnSomething(1, 1, 1);
        spawnSomething(2, 2, 2);

    }


    void spawnSomething(int clone, int spawn, int location)
    {
        whatToClonePrefab[clone] = Instantiate(
            whatToSpawnPrefab[spawn],
            spawnLocations[location],
            Quaternion.Euler(0, 90, 0))
            as GameObject;
    }
}
