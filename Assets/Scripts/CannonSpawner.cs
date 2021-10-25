using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBullet();
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
