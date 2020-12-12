using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemOnWorld : MonoBehaviour
{
    // Start is called before the first frame update
    public ItemDataModel itemDataModel;
    public float spinSpeed = 0.8f;
    //有背包的npc是否可以捡起此物品
    public bool npcAutoPickUp = false;
    //玩家是否触碰到物体
    private bool playerEnter = false;

    private 背包接口 bagif;
    
    
    void Update()
    {
        //让物体自旋
        spin();
        //监听玩家是否捡起物体
        playerPickup();
        
    }

    private void spin() {
        transform.Rotate(Vector3.up * spinSpeed, Space.Self);
    }
    private void playerPickup() {
        if (Input.GetKeyDown(KeyCode.G) && playerEnter == true)
        {
            
            if (AddNewItem(bagif)) Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ShowInventory inventory;
        //检查目标对象是否拥有背包
        if (other.GetComponent<ShowInventory>() != null)
        {
            inventory = other.GetComponent<ShowInventory>();
            bagif = inventory.bag;
            if (bagif.bag == null) {
                return;
            }
            //玩家触碰物品
            if (other.gameObject.CompareTag("Player"))
            {
                playerEnter = true;
            }
            //npc触碰物品
            else {
                if (npcAutoPickUp == true) {
                    
                    if(AddNewItem(bagif)) Destroy(gameObject);
                }
            }
        }
        else
        {
            return;
        }
    }
    public int findEmptySlotInBag(Inventory bag)
    {
        for (int i = 0; i < bag.itemList.Count; i++)
        {
            if (bag.itemList[i] == null || bag.itemList[i].itemType == "Empty")
            {
                Debug.Log(i);
                return i;
            }
        }
        Debug.Log(-1);
        return -1;
    }
    private int findSlotInBag(ItemDataModel item)
    {
        for (int i = 0; i < bagif.bag.itemList.Count; i++)
        {
            if (bagif.bag.itemList[i] == item)
            {
                return i;
            }
        }

        return -1;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerEnter = false;
    }
    public bool AddNewItem(背包接口 bagif) {

        Inventory Inventory = bagif.bag;
        if (!Inventory.itemList.Contains(itemDataModel))
        {
            int idx = findEmptySlotInBag(Inventory);
            if (idx == -1)
            {
                Debug.Log("no empty slot for store new item");
                return false;
            }
            
            itemDataModel.itemNumber += itemDataModel.addNumber;
            Inventory.itemList[idx] = itemDataModel;
            
            bagif.ShowNewItem(itemDataModel,idx);
        }
        else {
            
            itemDataModel.itemNumber += itemDataModel.addNumber;
            int idx = findSlotInBag(itemDataModel);
            
            bagif.ShowNewItem(itemDataModel,idx);
            
        }
        return true;
    }
}
