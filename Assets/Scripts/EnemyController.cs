using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float ftSpeedEnemy = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Enemy Initial Frame");
        Debug.DrawLine(transform.position, new Vector3(5, 0, 0), Color.red, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(ftSpeedEnemy, 0, 0) * Time.deltaTime;
    }

    private void MoveEnemy()
    {
        transform.Translate(ftSpeedEnemy * Time.deltaTime * Vector3.right);
    }
}
