using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryEntryUI : MonoBehaviour
{
    public InventoryItem entryData;

    public TMP_Text itemName;
    public TMP_Text itemDescription;
    public TMP_Text ownedAmount;

    public Image itemIcon;
    public Button useButton;

    public InventoryUI inventoryUI;

    public void Initialize(InventoryUI inventoryUI, InventoryItem entryData)
    {
        this.inventoryUI = inventoryUI;
        this.entryData = entryData;
        UpdateEntry();
    }

    public void UpdateEntry()
    {
        itemName.text = entryData.item.itemName;
        itemDescription.text = entryData.item.itemDescription;
        ownedAmount.text = "Owned: " + entryData.count.ToString();

        itemIcon.sprite = entryData.item.itemSprite;

        if (entryData.item.IsUsable())
        {
            useButton.gameObject.SetActive(true);
            useButton.GetComponentInChildren<TMP_Text>().text = entryData.item.UseText();
            useButton.onClick.AddListener(UseItem);
        }
        else
        {
            useButton.gameObject.SetActive(false);
        }
    }

    public void UseItem()
    {
        if (entryData.item.Use(GameObject.Find("Character")))
        {
            CharacterInventory.instance.RemoveItem(entryData.item);
            inventoryUI.UpdateView();
        }
    }
}
