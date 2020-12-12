using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canGift : MonoBehaviour
{
    public GameObject Gp;
    public void onClick()
    {
        SendGift.shopItem = null;
        Gp.SetActive(false);
    }
}
