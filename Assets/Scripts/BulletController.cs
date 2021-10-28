using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float ftSpeedBullet = 0.00f;
    public Vector3 direction;
    public int intDemage = 3;
    public float ftDestroyBulletByTime = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bullet Initial Frame");
        //Debug.DrawLine(transform.position, new Vector3(8, 8, -20), Color.red, 7f);

    }

    // Update is called once per frame
    void Update()
    {
        destroyBullet();


        ChangeScaleWithSpace();
    }
    private void ChangeScaleWithSpace() // Change scale with space
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.localScale *= 2;
        }
    }

    private void destroyBullet()
    {
        ftDestroyBulletByTime -= Time.deltaTime;
        if (ftDestroyBulletByTime > 0)
        {
            MoveBullet();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void MoveBullet()
    {
        transform.position += direction * ftSpeedBullet * Time.deltaTime;
    }
}
