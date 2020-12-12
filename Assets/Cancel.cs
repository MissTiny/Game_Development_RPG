using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cancel : MonoBehaviour
{
    public void OnClick()
    {
        Listener.lastlevel = 12;
        ShoppingCart.cleanCart();
        Application.LoadLevel(10);
    }
}
