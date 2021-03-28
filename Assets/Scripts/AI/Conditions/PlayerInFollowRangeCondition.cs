using UnityEngine;

[CreateAssetMenu(fileName = "Player in Follow Range Condition", menuName = "AI/Conditions/Player in Follow Range")]
public class PlayerInFollowRangeCondition : ConditionBase
{
    public override bool IsConditionMet(StateController controller)
    {
        if (TopdownCharacter.instance)
        {
            AIDetectionData data = controller.GetComponent<AIDetectionData>();
            if (data)
            {
                return (Vector2.Distance(TopdownCharacter.instance.transform.position, controller.transform.position) < data.playerFollowRange);
            }
        }
        return false;
    }
}
