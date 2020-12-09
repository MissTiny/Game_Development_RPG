using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem
{
    // Start is called before the first frame update
    public string ItemName;
    public string ItemDescription;
    public int Price;

    //teacher can be added in the future
    public ShopItem(string itemName, string itemDescription,int price){
        ItemName = itemName;
        ItemDescription = itemDescription;
        Price = price;
    }


}
