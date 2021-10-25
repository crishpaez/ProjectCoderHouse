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
    public Vector3 direction;
    public Vector3 initPosition = new Vector3(4, 4, 4);

    public GameObject swordPlayer;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initPosition;
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        Debug.Log(swordPlayer.GetComponent<SwordController>().GetSwordName());
        swordPlayer.GetComponent<SwordController>().SetSwordName("Claymore");
        Debug.Log(swordPlayer.GetComponent<SwordController>().GetSwordName());
        Thread.Sleep(3000);
        ChangeScale();

        //ConditionLifePlayer();
        DemageReceivedPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        ChangePosition();
    }

    // Methods
    
    void DemageReceivedPlayer()
    {
        if (intPlayerLife > 5 && intPlayerLife < 8)
        {
            Debug.Log("Demage +3");
            intPlayerLife -= 3;
        }
        else if (intPlayerLife == 8 || intPlayerLife == 10)
        {
            Debug.Log("Demage +5");
            intPlayerLife -= 5;
        }
    }

    //void ConditionLifePlayer()
    //{
    //    if (intPlayerLife > 1)
    //    {
    //        Debug.Log($"You're alive {intPlayerLife}");
    //    }
    //    else if (intPlayerLife == 1)
    //    {
    //        Debug.Log($"You're in danger {intPlayerLife}");
    //        intPlayerLife++;
    //    }
    //    else if (intPlayerLife == 0)
    //    {
    //        Debug.Log("Game over");
    //        Debug.Break();
    //    }
    //}


    //void DemageReceivedPlayerForTime(int intTime)
    //{
    //    while (intPlayerLife > 10)
    //    {
    //        intPlayerLife--;
    //        Thread.Sleep(intTime);
    //    }
    //}

    void ChangeScale() // cambiar escala
    {
        transform.localScale = newScale;
    }

    void ChangePosition() // desplazamiento
    {
        transform.position += direction * ftPlayerSpeed * Time.deltaTime;
    }
}
