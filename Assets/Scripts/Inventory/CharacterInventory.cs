using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    public static CharacterInventory instance;

    public List<InventoryItem> itemList = new List<InventoryItem>();

    private void Awake()
    {
        // Initialize singleton instance
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void AddItem(Item item)
    {
        int itemIndex = itemList.FindIndex(inventoryItem => inventoryItem.item == item);

        if (itemIndex != -1)
        {
            itemList[itemIndex].count += 1;
        }
        else
        {
            InventoryItem newItem = new InventoryItem();
            newItem.item = item; newItem.count = 1;
            itemList.Add(newItem);
        }
    }

    public bool RemoveItem(Item item)
    {
        int itemIndex = itemList.FindIndex(inventoryItem => inventoryItem.item == item);

        if (itemIndex != -1)
        {
            if (itemList[itemIndex].count > 1)
            {
                itemList[itemIndex].count -= 1;
            }
            else
            {
                itemList.RemoveAt(itemIndex);
            }
            return true;
        }
        else
        {
            return false;
        }
    }
}

[System.Serializable]
public class InventoryItem
{
    public Item item;
    public int count;
}