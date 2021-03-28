using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    public SkillController[] weapons;
    public int selectedWeapon;

    private void Start()
    {
        SelectWeapon(selectedWeapon);
    }

    private void Update()
    {
        if (Input.mouseScrollDelta.y != 0)
        {
            selectedWeapon += Mathf.RoundToInt(Mathf.Sign(Input.mouseScrollDelta.y));

            // We want to 'loop around' the index if it is out of range
            if (selectedWeapon == -1) selectedWeapon = weapons.Length - 1;
            if (selectedWeapon == weapons.Length) selectedWeapon = 0;

            SelectWeapon(selectedWeapon);
        }
    }

    private void SelectWeapon(int index)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i]?.gameObject.SetActive(i == index);
        }
    }
}
