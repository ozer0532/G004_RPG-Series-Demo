using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Test Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite itemSprite;

    public virtual bool IsUsable() => false;
    public virtual string UseText() => "";
    public virtual bool Use(GameObject target) => false;
}
