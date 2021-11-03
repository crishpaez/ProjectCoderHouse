using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlayerController : MonoBehaviour
{
    public int intPlayerLife = 3;
    public string strPlayerName = "Mr. HCP";
    public float ftPlayerSpeed;

    public Vector3 newScale;
    public Vector3 initPosition = new Vector3(4, 4, 4);

    public GameObject swordPlayer;
    float ftCameraAxisByX;
    float ftCameraAxisByY = 5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = initPosition;

        Debug.Log(swordPlayer.GetComponent<SwordController>().GetSwordName());
        swordPlayer.GetComponent<SwordController>().SetSwordName("Claymore");
        Debug.Log(swordPlayer.GetComponent<SwordController>().GetSwordName());

        DemageReceivedPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        rotatePlayer();
    }

    // Methods
    void movePlayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * ftPlayerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.TransformDirection(Vector3.back) * ftPlayerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.TransformDirection(Vector3.left) * ftPlayerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.TransformDirection(Vector3.right) * ftPlayerSpeed * Time.deltaTime;
        }
    }
    private void rotatePlayer()
    {
        ftCameraAxisByX += Input.GetAxis("Mouse X");
        //ftCameraAxisByY += Input.GetAxis("Mouse Y");
        Quaternion angle = Quaternion.Euler(0, ftCameraAxisByX, 0);
        transform.localRotation = angle;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
            
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        // Usar para el portal por el uso del Is tigger en el colisionador un posible toggle
        if (other.gameObject.CompareTag("Portal"))
        {
            

        }
    }
    //void DemageReceivedPlayer()
    //{
    //    if (intPlayerLife > 5 && intPlayerLife < 8)
    //    {
    //        Debug.Log("Demage +3");
    //        intPlayerLife -= 3;
    //    }
    //    else if (intPlayerLife == 8 || intPlayerLife == 10)
    //    {
    //        Debug.Log("Demage +5");
    //        intPlayerLife -= 5;
    //    }
    //}
}
