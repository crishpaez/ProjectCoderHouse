using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float ftSpeedProjectile = 0.00f;
    public Vector3 direction;
    public int intDemage = 3;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Projectile Initial Frame");
        //Debug.DrawLine(transform.position, new Vector3(8, 8, -20), Color.red, 7f);

    }

    // Update is called once per frame
    void Update()
    {
        MoveProjectiles();
    }
    private void MoveProjectiles()
    {
        transform.position += new Vector3(ftSpeedProjectile, 0, 0) * Time.deltaTime;
    }
    //private void MoveProjectile()
    //{
    //    transform.Translate(ftSpeedProjectile * Time.deltaTime * direction);
    //}
}
