using UnityEngine;

public class WeaponSwitcher2 : MonoBehaviour
{
    public GameObject[] weapons;
    public int selectedWeapon;

    private void Start()
    {
        SelectWeapon(selectedWeapon);
    }

    private void Update()
    {
        if (Input.mouseScrollDelta.y != 0)
        {
            int direction = Mathf.RoundToInt(Mathf.Sign(Input.mouseScrollDelta.y));
            selectedWeapon += direction;
        
            if (selectedWeapon < 0)
            {
                selectedWeapon = weapons.Length - 1;
            }
            else if (selectedWeapon >= weapons.Length) 
            {
                selectedWeapon = 0;
            }

            SelectWeapon(selectedWeapon);
        }
    }

    public void SelectWeapon(int index)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].SetActive(i == index);
        }
    }
}
