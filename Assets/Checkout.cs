using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class Checkout : MonoBehaviour
{


    public void OnClick()
    {
        ShoppingCart.addtoBag();
        ShoppingCart.cleanCart();
        ShoppingCart.setshopped(true);
    }
}
