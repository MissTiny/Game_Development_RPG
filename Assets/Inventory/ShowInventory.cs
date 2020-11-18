using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//简介：此脚本用于显示背包panel 和 装备panel， 两个panel为Inventory_Canvas的子物体

//Inventory_Canvas： 定义：物品栏画布，包含子物体：背包和装备栏，
//              

//脚本用法：将脚本挂载在需要背包的人物上，然后为脚本挂载上需要显示的  背包panel和装备panel
//    注意：所挂载的背包和物品栏panel必须存在于当前场景scene，请将 新定义的背包类panel都定义为Inventory Canvas的子物体

//脚本显示逻辑：
//            1. 如果背包和装备栏拥有者是玩家（tag为player），则 I 打开背包， e打开装备栏
//            2. 如果items_Canvas的拥有者是NPC，暂未定义打开方式（但键盘i，o无法打开npc的背包和装备栏）


public class ShowInventory : MonoBehaviour
{
    public GameObject Equip_panel;
    public GameObject Bag_panel;
    public Inventory bag;
    public bagSlotInterface slotPrefab;
    public bool reStartGameEmptyBag;
    private 背包显示接口 bagIt;

    private GameObject slotGrid;
    private Text description;
    private bool iopen = false;
    private bool eopen = false;
    //private GameObject parent;
    private bool isPlayer;
    // Start is called before the first frame update
    void Start()
    {
        bagIt = Bag_panel.GetComponent<背包显示接口>();
        slotGrid = bagIt.grid;
        description = bagIt.description;
        init();
        //parent = transform.parent.gameObject;
        isPlayer = tag == "Player";
    }

    private void init()
    {
        if (reStartGameEmptyBag) {
            clearPanelAndData();
        }
        RefreshItem();
        description.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer && Input.GetKeyDown(KeyCode.I))
        {
            OpenBag();
        }
        if (isPlayer && Input.GetKeyDown(KeyCode.E))
        {
            OpenEquip();
        }
    }
    void OpenEquip()
    {
        
            eopen = Equip_panel.active;
            eopen = !eopen;
            Equip_panel.SetActive(eopen);
        
    }
    void OpenBag()
    {
            iopen = Bag_panel.active;
            iopen = !iopen;
            Bag_panel.SetActive(iopen);
        
    }

    public void updateItemDescription(string Description) {
        description.text= Description;
    }

    private void clearPanelAndData() {
        for (int i = 0; i < bag.itemList.Count; i++)
        {
            bag.itemList[i].itemNumber = 0;
        }
        bag.itemList.Clear();
        clearBagShowing();
    }

    //根据给的itemDataModel，item的数据实体创建对应的背包显示外观prefab，并显示在背包里
    public void ShowNewItem(ItemDataModel itemDataModel) {
        bagSlotInterface newItem = Instantiate(slotPrefab,slotGrid.transform.position,Quaternion.identity);
        if (newItem == null) {
            
            return;
        }
        newItem.gameObject.transform.SetParent(slotGrid.transform);
        newItem.slotItem = itemDataModel;
        newItem.slotImage.sprite = itemDataModel.itemImage;
        newItem.number.text = itemDataModel.itemNumber.ToString();
        
    }

    

    public void RefreshItem() {
        clearBagShowing();
        showAllItem();
    }

    //clear all the prefab in the bag, but the data of items will still be there
    public void clearBagShowing() {
        for (int i = 0; i < slotGrid.transform.childCount; i++)
        {
            Destroy(slotGrid.transform.GetChild(i).gameObject);
        }
    }

    //重新把inventory（背包的数据实体，不是显示的panel）里的item重新加载到panel上
    private void showAllItem() {
        for (int i = 0;i<bag.itemList.Count;i++) {
            ShowNewItem(bag.itemList[i]);
        }
    }

    
}
