using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class Checkout : MonoBehaviour
{
    public Inventory shopbag;
    public 背包接口 bag;
    public itemOnWorld itemOnWorld;

    public void OnClick()
    {
        ShoppingCart.cleanCart();
        ShoppingCart.setshopped(true);
        ItemDataModel itemDataModel= shopbag.itemList[0];
        Instantiate(itemOnWorld, transform.position, Quaternion.identity);

        itemOnWorld newItem = Instantiate(itemOnWorld, new Vector2(0,0), Quaternion.identity);
        newItem.GetComponent<SpriteRenderer>().sprite = itemDataModel.itemImage;
        newItem.itemDataModel = itemDataModel;
        newItem.transform.SetParent(transform);
        newItem.AddNewItem(bag);
    }
}
