using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/New Item Data Model")]
public class ItemDataModel : ScriptableObject
{
    // Start is called before the first frame update
    public string itemName;
    public Sprite itemImage;
    //背包里有多少
    public int itemNumber;
    //在游戏中捡起来时 有多少，也就是每次捡起增加多少
    public int addNumber;
    //"shoe" "leftHand" "rightHand" "normal" "hat"
    public string itemType;
    [TextArea]
    public string itemInfo;

    
}
