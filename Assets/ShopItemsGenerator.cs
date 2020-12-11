using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class ShopItemsGenerator : MonoBehaviour
{
    public GameObject item_btn = null;
    public Canvas Course_Canvas = null;
    public GameObject Content = null;


    void Start()
    {
        ScrollMenu();
    }

    // Update is called once per frame
    void Update()
    {
        //ScrollMenu();
    }
    private void ScrollMenu()
    {
//        var children = new List<GameObject>();
//        foreach (Transform child in Content.transform) children.Add(child.gameObject);
//        children.ForEach(child => Destroy(child));
        ShopItemList shopItemList = new ShopItemList();
        for (int i = 0; i < shopItemList.ShopItems.Count; i = i++)
        {
//            GameObject item = Instantiate(item_btn, Content.transform);
//            Text text = item.GetComponentInChildren<Text>();
//            text.text = shopItemList.ShopItems[i].ItemName;
            print(shopItemList.ShopItems[i].ItemName);
        }
    }
}
