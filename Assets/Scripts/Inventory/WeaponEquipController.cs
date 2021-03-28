using UnityEngine;

public class WeaponEquipController : MonoBehaviour
{
    public SkillController currentWeapon;
    public Transform parentTransform;

    public void EquipWeapon(GameObject weaponPrefab)
    {
        if (currentWeapon)
        {
            Destroy(currentWeapon.gameObject);
        }

        GameObject newWeapon = Instantiate(weaponPrefab, parentTransform.position, Quaternion.identity, parentTransform);
        currentWeapon = newWeapon.GetComponent<SkillController>();
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
