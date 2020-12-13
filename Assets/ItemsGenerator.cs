using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class ItemsGenerator : MonoBehaviour
{
    public GameObject item_btn;
    public Canvas Course_Canvas;
    public GameObject Content;
    public Text money;


    void Start()
    {
        ScrollMenu();
    }

    // Update is called once per frame
    void Update()
    {
        //ScrollMenu();
        money.text = "$: " + Ability.moneyTotal.ToString();
    }
    private void ScrollMenu()
    {
        var children = new List<GameObject>();
        foreach (Transform child in Content.transform) children.Add(child.gameObject);
        children.ForEach(child => Destroy(child));
        ShopItemList shopItemList = new ShopItemList();
        for (int i = 0; i < shopItemList.ShopItems.Count; i++)
        {
            Debug.Log(shopItemList.ShopItems[i].ItemName);
            GameObject item = Instantiate(item_btn, Content.transform);
            Text text = item.GetComponentInChildren<Text>(); 
            text.text = shopItemList.ShopItems[i].ItemName + $" ${shopItemList.ShopItems[i].Price}";
        }
    }
}
