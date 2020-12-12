using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class ShoppingCart : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    private static ShopItem ShopItem = null;
    private static bool shopped = false;
    public GameObject shopper1;
    public GameObject shopper2;
    void Start()
    {
        text.text = "What can I help you?";
        ShopItem = null;
        shopped = false;
        shopper1.SetActive(true);
        shopper2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { 
        if (ShopItem == null && !shopped)
        {
            shopper1.SetActive(true);
            shopper2.SetActive(false);
            text.text = "What can I help you?";
        }
        else if(!(ShopItem == null) && !shopped)
        {
            shopper1.SetActive(true);
            shopper2.SetActive(false);
            text.text = ShopItem.ItemDescription;
        }else if (shopped && (ShopItem == null))
        {
            shopper1.SetActive(false);
            shopper2.SetActive(true);
            text.text = "Thanks for buying!";
        }
    }

    public static void setShopItem(ShopItem shopItem )
    {
        ShopItem = shopItem;
    }
    public static void cleanCart()
    {
        ShopItem = null;
    }
    public static void setshopped( bool s)
    {
        shopped = s;
    }
}
