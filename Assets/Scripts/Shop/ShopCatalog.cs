using System.Collections.Generic;
using UnityEngine;

public class ShopCatalog : MonoBehaviour
{
    public List<ShopItem> itemList = new List<ShopItem>();
    public string shopName;

    public void AddItem(Item item, int price)
    {
        int itemIndex = itemList.FindIndex(shopItem => shopItem.item == item);

        if (itemIndex != -1)
        {
            itemList[itemIndex].stock += 1;
        }
        else
        {
            ShopItem newItem = new ShopItem();
            newItem.item = item; newItem.stock = 1; newItem.price = price;
            itemList.Add(newItem);
        }
    }

    public bool RemoveItem(Item item)
    {
        int itemIndex = itemList.FindIndex(shopItem => shopItem.item == item);

        if (itemIndex != -1)
        {
            if (itemList[itemIndex].stock > 0)
            {
                itemList[itemIndex].stock -= 1;
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
public class ShopItem
{
    public Item item;
    public int stock;
    public int price;
}