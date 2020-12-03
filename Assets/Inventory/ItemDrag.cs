using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ItemDrag : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    private Transform originalParent;
    private slotItemInterface curItem;
    private Inventory bag;
    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        
        transform.SetParent(transform.parent.parent);
        transform.position = eventData.position;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        Debug.Log(eventData.pointerCurrentRaycast.gameObject.name);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GameObject pointerObject = eventData.pointerCurrentRaycast.gameObject;
        

        if (pointerObject.name == "slotItem(Clone)")
        {
            slotItemInterface pointerItem = pointerObject.GetComponent<slotItemInterface>();
            Debug.Log(pointerObject.name == "slotItem(Clone)");
            swapItems(curItem,pointerItem);

            
            transform.SetParent(pointerObject.transform.parent);
            transform.position = pointerObject.transform.parent.position;
            pointerObject.transform.position = originalParent.position;
            pointerObject.transform.SetParent(originalParent);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
            return;
        }
        else if (pointerObject.name == "bagSlot(Clone)")
        {
            Inventory inventory1 = curItem.transform.parent.parent.GetComponent<背包接口>().bag;
            Inventory inventory2 = pointerObject.transform.parent.parent.GetComponent<背包接口>().bag;
            int idx1 = originalParent.GetComponent<bagSlotIF>().index;
            int idx2 = pointerObject.GetComponent<bagSlotIF>().index;

            ItemDataModel temp = inventory1.itemList[idx1];
            inventory1.itemList[idx1] = inventory2.itemList[idx2];
            inventory2.itemList[idx2] = temp;

            transform.SetParent(pointerObject.transform);
            transform.position = pointerObject.transform.position;
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
        else {

        }
        
    }
    private void swapItems(slotItemInterface item1, slotItemInterface item2) {
        
        Inventory inventory1 = item1.transform.parent.parent.gameObject.GetComponent<背包接口>().bag;
        Inventory inventory2 = item2.transform.parent.parent.parent.gameObject.GetComponent<背包接口>().bag;
        
        int idx1 = originalParent.GetComponent<bagSlotIF>().index;
        int idx2 = item2.transform.parent.GetComponent<bagSlotIF>().index;
        

        inventory1.itemList[idx1] = item2.slotItem;
        inventory2.itemList[idx2] = item1.slotItem;
    }


    // Start is called before the first frame update
    void Start()
    {
        
        curItem = GetComponent<slotItemInterface>();
        bag = transform.parent.parent.GetComponent<背包接口>().bag;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
