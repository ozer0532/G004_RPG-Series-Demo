using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopUI : MonoBehaviour
{
    public ShopCatalog catalog;

    public Canvas shopCanvas;

    public VerticalLayoutGroup entryLayoutGroup;
    public TMP_Text coinText;
    public TMP_Text shopNameDisplay;
    public Animator anim;

    public GameObject shopEntryPrefab;
    public List<ShopEntryUI> shopEntryList = new List<ShopEntryUI>();

    // Start is called before the first frame update
    void Start()
    {
        shopCanvas.enabled = false;
    }

    public void OpenShop(ShopCatalog catalog)
    {
        this.catalog = catalog;
        shopNameDisplay.text = catalog.shopName;
        anim.Play("Open");
        UpdateView();
    }

    public void CloseShop()
    {
        anim.Play("Close");
    }

    public void UpdateView()
    {
        // Destroy GameObjects
        foreach (ShopEntryUI entry in shopEntryList)
        {
            Destroy(entry.gameObject);
        }
        // Delete entries
        shopEntryList = new List<ShopEntryUI>();

        // Draw the entries
        foreach (ShopItem entry in catalog.itemList)
        {
            GameObject entryObject = Instantiate(shopEntryPrefab, entryLayoutGroup.transform);
            ShopEntryUI entryUI = entryObject.GetComponent<ShopEntryUI>();

            entryUI.Initialize(this, entry);
            shopEntryList.Add(entryUI);
        }

        coinText.text = MoneyManager.coins.ToString();
    }
}
