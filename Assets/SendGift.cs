using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendGift : MonoBehaviour
{
    public Text text;

    public static ShopItem shopItem;

    private void Start()
    {
        shopItem = null;
        text.text = "";
    }

    private void Update()
    {
        if(shopItem != null)
        {
            text.text = shopItem.ItemDescription;
        }
        else
        {
            text.text = "";
        }
    }
}
