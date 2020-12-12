using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text1;
    private ShopItemList ShopItemList = new ShopItemList();
    public void OnClick(){

        for (int i = 0; i < ShopItemList.ShopItems.Count; i++)
        {
            if (ShopItemList.ShopItems[i].Equals(text1.text))
            {
                SendGift.shopItem = ShopItemList.ShopItems[i];
                Debug.Log(11111111111111);
                break;
            }
        }
    }
}
