using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float ftSpeedEnemy = 5.0f;
    [SerializeField] private Enemies enemy;
    private GameObject player;

    enum Enemies { EnemyOne, EnemyTwo, None };
    bool isFoward = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }
    // Update is called once per frame
    void Update()
    {
        EnemyTowards();
    }
    private void EnemyTowards()
    {
        switch (enemy)
        {
            case Enemies.EnemyOne:
                LookEnemyOne(.5f);
                break;
            case Enemies.EnemyTwo:
                MoveTowards();
                LookAtPlayer();
                break;
            case Enemies.None:
                break;
            default:
                break;
        }
    }

    //private void MoveEnemy(Vector3 direction)
    //{
    //    transform.Translate(ftSpeedEnemy * Time.deltaTime * direction);
    //}
    private void LookEnemyOne(float ftSpeedToLook)
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, ftSpeedToLook * Time.deltaTime);
    }
    private void MoveTowards()
    {
        Vector3 direction = player.transform.position - transform.position;
        if (direction.magnitude > 1.2)
        {
            transform.position += ftSpeedEnemy * direction.normalized * Time.deltaTime;
        }        
    }
    private void LookAtPlayer()
    {
        Vector3 direction = player.transform.position - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(direction);
        transform.rotation = newRotation;
    }
}
