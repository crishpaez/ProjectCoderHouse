using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float ftSpeedBullet= 0.00f;
    public Vector3 direction;
    public int intDemage = 3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bullet Initial Frame");
        //Debug.DrawLine(transform.position, new Vector3(8, 8, -20), Color.red, 7f);
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        transform.position += direction * ftSpeedBullet * Time.deltaTime;
        //transform.position += new Vector3(ftSpeedBullet, 0, 0) * Time.deltaTime;
        //transform.Translate(ftSpeedBullet * Time.deltaTime * direction);
    }
}
