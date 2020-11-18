using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.EventSystems;
public class bagSlotInterface: MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    // Start is called before the first frame update
    public ItemDataModel slotItem;
    public Image slotImage;
    public Text number;
    public GameObject ItemInfoPanel;
    private bool open;
    public void Start()
    {
        ItemInfoPanel.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData) {
        Debug.Log("YESYES");
        ItemInfoPanel.GetComponentInChildren<Text>().text = slotItem.itemInfo;
        Vector2 objectPos = GetComponent<RectTransform>().position;
        Vector2 newposition = new Vector2(objectPos.x+ 100, objectPos.y + 30);
        ItemInfoPanel.GetComponent<RectTransform>().position = newposition;
        ItemInfoPanel.SetActive(true);

    }

    public void OnPointerExit(PointerEventData eventData) {
        ItemInfoPanel.SetActive(false);
    }

    
}
