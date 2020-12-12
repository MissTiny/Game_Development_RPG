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
    public 背包接口 bag;




    private CanvasGroup bagCanvasGroup;
    private CanvasGroup equipCanvasGroup;
    private bool iopen = false;
    private bool eopen = false;
    //private GameObject parent;
    private bool isPlayer;
    // Start is called before the first frame update
    void Start()
    {
        //equipCanvasGroup = Equip_panel.GetComponent<CanvasGroup>();
        bagCanvasGroup = bag.GetComponent<CanvasGroup>();
        bag.gameObject.SetActive(true);
        Hide(bagCanvasGroup);
        isPlayer = tag == "Player";
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
            //Show();
            Equip_panel.SetActive(eopen);
        
    }
    void OpenBag()
    {
        //iopen = bag.gameObject.active;
        iopen = bagCanvasGroup.alpha == 0f ? true : false;
        
        if (iopen)
        {
            Show(bagCanvasGroup);
        }
        else {
            Hide(bagCanvasGroup);
        }
        
        //bag.gameObject.SetActive(iopen);
        
    }

    void Hide(CanvasGroup cg)
    {
        cg.alpha = 0f; //this makes everything transparent
        cg.blocksRaycasts = false; //this prevents the UI element to receive input events
    }

    void Show(CanvasGroup cg)
    {
        cg.alpha = 1f;
        cg.blocksRaycasts = true;
    }











}
