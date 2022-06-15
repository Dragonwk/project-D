using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    private Vector3 spawnpos;
    public GameObject spawnOjbect;
    private float Duration;
    public float x, y, z;
    #region Singleton

    public static spawn Instance;

    private void Awake()
    {
        Instance = this;
    }

    #endregion

    private void Start()
    {
        spawnpos = new Vector3(x, y, z);
        //spawnpos = transform.position;

    }

    void SpawnNewObject()
    {
        Instantiate(spawnOjbect, spawnpos, Quaternion.identity);
    }

    public void NewSpawnRequest()
    {
        Invoke(methodName: "SpawnNewObject", Duration);
    }

}
