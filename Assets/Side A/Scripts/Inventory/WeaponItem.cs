using UnityEngine;

namespace Tutorial
{
    [CreateAssetMenu(fileName = "New Weapon Item 4 Tutor", menuName = "Item/Weapon 4 tutor")]
    public class WeaponItem : ConsumableItem
    {
        public GameObject weaponPrefab;

        public override string UseText() => "Equip";

        public override bool IsUsable() => true;

        public override bool Use(GameObject target)
        {
            WeaponEquipController equipper = target.GetComponent<WeaponEquipController>();

            if (equipper)
            {
                equipper.EquipWeapon(this);
            }

            return false;
        }
    }
}
