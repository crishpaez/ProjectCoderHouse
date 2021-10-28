using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject[] cameras;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CamSelect();
    }

    void CamSelect()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            EnableDisableCam(0, cameras);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            EnableDisableCam(1, cameras);
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            EnableDisableCam(2, cameras);
        }
        
    }
    private void EnableDisableCam( int numberCamEnable, GameObject[] arrCamera)
    {
            for (int i = 0; i < arrCamera.Length; i++)
            {
                if (i.Equals(numberCamEnable))
                {
                    cameras[numberCamEnable].SetActive(true);
                }
                else
                {
                    cameras[i].SetActive(false);
                }
            }
    }
}
