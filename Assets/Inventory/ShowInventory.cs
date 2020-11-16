using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//简介：此脚本是挂载在item_Canvas上的控制脚本（item_Canvas定义如下）

//items_Canvas： 定义：物品栏画布，包含子物体背包和装备栏，
//               用法：可挂载在任意人物类GameObject上使其拥有背包和装备栏

//脚本用法：将脚本挂载在item_Canvas上（已自动挂好）

//脚本目的：控制背包和装备栏显示，显示逻辑如下：
//                     1. 如果items_Canvas的拥有者是玩家，则 I 打开背包， e打开装备栏
//                     2. 如果items_Canvas的拥有者是NPC，暂未定义打开方式（但键盘i，o无法打开npc的背包和装备栏）


public class ShowInventory : MonoBehaviour
{
    public GameObject Equip_panel;
    public GameObject Bag_panel;
    private bool iopen = false;
    private bool eopen = false;
    private GameObject parent;
    private bool isPlayer;
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject;
        isPlayer = parent.tag == "Player";
    }

    // Update is called once per frame
    void Update()
    {
        OpenBag();
        OpenEquip();
    }
    void OpenEquip()
    {
        if (isPlayer && Input.GetKeyDown(KeyCode.E))
        {
            eopen = Equip_panel.active;
            eopen = !eopen;
            Equip_panel.SetActive(eopen);
        }
    }
    void OpenBag()
    {
        if (isPlayer && Input.GetKeyDown(KeyCode.I))
        {
            iopen = Bag_panel.active;
            iopen = !iopen;
            Bag_panel.SetActive(iopen);
        }
    }
}
