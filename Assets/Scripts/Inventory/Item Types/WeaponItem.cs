using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Item", menuName = "Item/Weapon")]
public class WeaponItem : ConsumableItem
{
    public GameObject weaponPrefab;

    public override string UseText() => "Equip";

    public override bool Use(GameObject target)
    {
        WeaponEquipController equip = target.GetComponent<WeaponEquipController>();
        if (equip)
        {
            equip.EquipWeapon(weaponPrefab);
        }
        return false;
    }
}
