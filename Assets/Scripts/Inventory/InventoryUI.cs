using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public Canvas inventoryCanvas;

    public VerticalLayoutGroup entryLayoutGroup;
    public TMP_Text coinText;
    public Animator anim;

    public GameObject inventoryEntryPrefab;
    public List<InventoryEntryUI> inventoryEntryList = new List<InventoryEntryUI>();

    private void Start()
    {
        inventoryCanvas.enabled = false;
    }

    public void OpenInventory()
    {
        anim.Play("Open");
        UpdateView();
    }

    public void CloseInventory()
    {
        anim.Play("Close");
    }

    public void UpdateView()
    {
        // Destroy GameObjects
        foreach (InventoryEntryUI entry in inventoryEntryList)
        {
            Destroy(entry.gameObject);
        }
        // Delete entries
        inventoryEntryList = new List<InventoryEntryUI>();

        // Draw the entries
        foreach (InventoryItem entry in CharacterInventory.instance.itemList)
        {
            GameObject entryObject = Instantiate(inventoryEntryPrefab, entryLayoutGroup.transform);
            InventoryEntryUI entryUI = entryObject.GetComponent<InventoryEntryUI>();

            entryUI.Initialize(this, entry);
            inventoryEntryList.Add(entryUI);
        }

        coinText.text = MoneyManager.coins.ToString();
    }
}
