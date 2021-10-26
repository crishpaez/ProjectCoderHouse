using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;
    
    public float ftIntervalTimeSpawnBullet =1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet", 3f, ftIntervalTimeSpawnBullet);        
    }

    // Update is called once per frame
    void Update()
    {
    }
      

    void SpawnBullet()
    {
        Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, transform.rotation);
    }
}
