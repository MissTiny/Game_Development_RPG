using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 背包接口 : MonoBehaviour
{
    //背包外观及其布局  
    public Text description;
    public GameObject grid;
    public Text bagTitle;
    
    //数据结构 
    public Inventory bag;
    //背包单元格
    public bagSlotIF bagSlot;
    public slotItemInterface slotItemPrefab;
    //背包特性
    public bool reStartGameEmptyBag;

    

    public void ShowNewItem(ItemDataModel itemDataModel, int idx)
    {
        if (itemDataModel == null || itemDataModel.itemType == "Empty")
        {
            return;
        }
        destroySlotItem(idx);
        GameObject father = getSubObjectByIndex(grid, idx);
        slotItemInterface newItem = Instantiate(slotItemPrefab, father.transform.position, Quaternion.identity);
        if (newItem == null)
        {
            return;
        }

        newItem.gameObject.transform.SetParent(father.transform);
        newItem.slotItem = itemDataModel;
        newItem.slotImage.sprite = itemDataModel.itemImage;
        newItem.number.text = itemDataModel.itemNumber.ToString();
    }

    private GameObject getSubObjectByIndex(GameObject father, int idx)
    {
        return father.transform.GetChild(idx).gameObject;
    }

    private void destroySlotItem(int idx)
    {
        GameObject father = getSubObjectByIndex(grid, idx);
        for (int j = 0; j < father.transform.childCount; j++)
        {
            Destroy(father.transform.GetChild(j).gameObject);
        }
    }

    private void initBagData()
    {
        //init world items
        GameObject items = GameObject.Find("worldItems");
        if (items != null)
        {
            for (int i = 0; i < items.transform.childCount; i++)
            {
                items.transform.GetChild(i).GetComponent<itemOnWorld>().itemDataModel.itemNumber = 0;
            }
        }
        //init bag
        List<ItemDataModel> list = bag.itemList;
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log("asdfasdfadfadfadfa");
            Debug.Log(!(list[i] == null));
            if (!(list[i] == null)) {
                Debug.Log(list[i].itemName);
                list[i].itemNumber = 0;
            }

        }
        list.Clear();
        for (int i = 0; i < bag.initCapacity; i++)
        {
            bag.itemList.Add(null);
        }
    }

    public void initBagShowing()
    {
        for (int i = 0; i < grid.transform.childCount; i++)
        {
            Destroy(grid.transform.GetChild(i).gameObject);
        }

        for (int i = 0; i < bag.initCapacity; i++)
        {

            bagSlotIF newItem = Instantiate(bagSlot, grid.transform.position, Quaternion.identity);
            newItem.index = i;
            newItem.transform.SetParent(grid.transform);
        }
        description.text = "";
        //showAllItem();
    }

    private void init() {
        if (reStartGameEmptyBag)
        {
            initBagData();
            initBagShowing();
        }
        else {
            Refresh();
        }
    }
    private void Refresh() {
        for (int i = 0; i < grid.transform.childCount; i++)
        {
            Destroy(grid.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < bag.itemList.Count; i++)
        {
            bagSlotIF bs = Instantiate(bagSlot, grid.transform.position, Quaternion.identity);
            bs.index = i;
            bs.transform.SetParent(grid.transform);

            ItemDataModel itemDataModel = bag.itemList[i];
            if (itemDataModel == null || itemDataModel.itemType == "Empty")
            {
                continue;
            }

            GameObject father = bs.gameObject;
            slotItemInterface newItem = Instantiate(slotItemPrefab, father.transform.position, Quaternion.identity);
            if (newItem == null)
            {
                return;
            }

            newItem.gameObject.transform.SetParent(father.transform);
            newItem.slotItem = itemDataModel;
            newItem.slotImage.sprite = itemDataModel.itemImage;
            newItem.number.text = itemDataModel.itemNumber.ToString();
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    // Update is called once per frame
    void Update()
    {

    }
}