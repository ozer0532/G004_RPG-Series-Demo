using UnityEngine;

public class ConsumableItem : Item
{
    public override bool IsUsable() => true;
    public override string UseText() => "Consume";
}
