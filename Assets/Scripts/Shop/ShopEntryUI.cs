using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopEntryUI : MonoBehaviour
{
    public ShopItem entryData;

    public TMP_Text itemName;
    public TMP_Text itemDescription;
    public TMP_Text ownedAmount;
    public TMP_Text priceDisplay;

    public Image itemIcon;
    public Button useButton;

    public ShopUI shopUI;

    public void Initialize(ShopUI shopUI, ShopItem entryData)
    {
        this.shopUI = shopUI;
        this.entryData = entryData;
        UpdateEntry();
    }

    public void UpdateEntry()
    {
        itemName.text = entryData.item.itemName;
        itemDescription.text = entryData.item.itemDescription;
        ownedAmount.text = "Stock: " + entryData.stock.ToString();
        priceDisplay.text = entryData.price.ToString();

        itemIcon.sprite = entryData.item.itemSprite;

        if (entryData.stock > 0)
        {
            useButton.interactable = true;
            useButton.onClick.AddListener(BuyItem);
        }
        else
        {
            useButton.interactable = false;
        }
    }

    public void BuyItem()
    {
        if (MoneyManager.coins >= entryData.price)
        {
            MoneyManager.RemoveCoins(entryData.price);

            CharacterInventory.instance.AddItem(entryData.item);

            entryData.stock -= 1;

            shopUI.UpdateView();
        }
    }
}
