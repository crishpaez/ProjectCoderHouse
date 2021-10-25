using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject[] projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnProjectile();
        InvokeRepeating("SpawnProjectile", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnProjectile()
    {
        int projectileIndex = Random.Range(0, projectilePrefab.Length);
        Instantiate(projectilePrefab[projectileIndex], transform.position, projectilePrefab[projectileIndex].transform.rotation);
    }
    
}
