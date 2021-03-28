using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Health Potion", menuName = "Item/Health Potion")]
public class HealthPotion : ConsumableItem
{
    public int healAmount = 0;

    public override bool Use(GameObject target)
    {
        Destructible destructibleComponent = target.GetComponent<Destructible>();

        if (destructibleComponent.currentHealth < destructibleComponent.maxHealth)
        {
            destructibleComponent.currentHealth += healAmount;
            destructibleComponent.currentHealth = Mathf.Clamp(destructibleComponent.currentHealth, 0, destructibleComponent.maxHealth);
            return true;
        }
        else
        {
            return false;
        }
    }
}
