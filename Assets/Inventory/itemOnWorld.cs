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

    private Inventory inventory;
    private ShowInventory showInventory;
    
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
            
            if (AddNewItem(inventory)) Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //检查目标对象是否拥有背包
        if (other.GetComponent<ShowInventory>() != null)
        {
            showInventory = other.GetComponent<ShowInventory>();
            inventory =showInventory.bag;
            if (inventory == null) {
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
                    
                    if(AddNewItem(inventory)) Destroy(gameObject);
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
            if (bag.itemList[i] == null)
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
        for (int i = 0; i < inventory.itemList.Count; i++)
        {
            if (inventory.itemList[i] == item)
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
    public bool AddNewItem(Inventory Inventory) {
        
        
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
            
            showInventory.ShowNewItem(itemDataModel,idx);
        }
        else {
            
            itemDataModel.itemNumber += itemDataModel.addNumber;
            showInventory.ShowNewItem(itemDataModel, findSlotInBag(itemDataModel));
            
        }
        return true;
    }
}
