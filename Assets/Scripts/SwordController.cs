using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    public string strSwordName = "Undefined";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Methods
    public string GetSwordName()
    {
        return strSwordName;
    }

    public void SetSwordName(string strSwordName)
    {
        this.strSwordName = strSwordName;
    }
}
