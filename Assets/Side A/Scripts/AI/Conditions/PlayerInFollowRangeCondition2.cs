using UnityEngine;

[CreateAssetMenu(fileName = "Player In Follow Range Condition", menuName = "AI/Conditions/Player In Follow Range 2")]
public class PlayerInFollowRangeCondition2 : ConditionBase2
{
    public override bool CheckCondition(StateController2 controller)
    {
        AIDetectionData2 data = controller.GetComponent<AIDetectionData2>();

        if (data)
        {
            Vector3 playerPosition = TopdownCharacter.instance.transform.position;
            Vector3 agentPosition = controller.transform.position;

            float distance = Vector2.Distance(playerPosition, agentPosition);

            return distance < data.followRange;
        }
        return false;
    }
}
