using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-6, 4, 3);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    private void LateUpdate()
    {
        FollowCam();
    }
    private void FollowCam()
    {
        transform.position = player.transform.position + offset;
    }
}
