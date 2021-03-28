using UnityEngine;

[CreateAssetMenu(fileName = "Player in Attack Range Condition", menuName = "AI/Conditions/Player in Attack Range")]
public class PlayerInAttackRangeCondition : ConditionBase
{
    public override bool IsConditionMet(StateController controller)
    {
        if (TopdownCharacter.instance)
        {
            AIDetectionData data = controller.GetComponent<AIDetectionData>();
            if (data)
            {
                return (Vector2.Distance(TopdownCharacter.instance.transform.position, controller.transform.position) < data.playerAttackRange);
            }
        }
        return false;
    }
}
