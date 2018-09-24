using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Collection/Item")]
public class Items : ScriptableObject{
    public string itemID;
    new public string name;
    public Sprite icon = null;
    public string itemDescription;
    public int itemCount;

    public Items(string itemNum, string itemName, string itemDescription, int itemCount)
    {
        this.itemID = itemNum;
        this.name = itemName;
        this.itemDescription = itemDescription;
        this.itemCount = itemCount;
    }
}
