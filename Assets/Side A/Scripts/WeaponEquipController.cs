using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorial
{
    public class WeaponEquipController : MonoBehaviour
    {
        public SkillController2 currentWeapon;
        public Transform parent;

        public void EquipWeapon(WeaponItem weaponItem)
        {
            UnequipWeapon();

            GameObject weapon = Instantiate(weaponItem.weaponPrefab, parent.position, parent.rotation, parent);
            currentWeapon = weapon.GetComponent<SkillController2>();
            currentWeapon.owner = gameObject;
        }

        public void UnequipWeapon()
        {
            if (currentWeapon)
            {
                Destroy(currentWeapon.gameObject);
            }

            currentWeapon = null;
        }
    }
}
