using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class ItemScript : MonoBehaviour
{
    public Text text;
    private ShopItemList ShopItemList = new ShopItemList();
    public void OnClick()
    {
        for(int i = 0; i < ShopItemList.ShopItems.Count; i++)
        {
            if (ShopItemList.ShopItems[i].ItemName.Equals(text.text))
            {
                ShoppingCart.setShopItem(ShopItemList.ShopItems[i]);
                ShoppingCart.setshopped(false);
                break;
            }
        }
    }
}
