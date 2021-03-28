using UnityEngine;

[CreateAssetMenu(fileName = "Move Towards Player Action", menuName = "AI/Actions/Move Towards Player 2")]
public class MoveTowardsPlayerAction2 : ActionBase2
{
    public override void DoAction(StateController2 controller)
    {
        Rigidbody2D rb2d = controller.GetComponent<Rigidbody2D>();
        AIMovementData2 data = controller.GetComponent<AIMovementData2>();

        if (rb2d && data)
        {
            Vector3 playerPosition = TopdownCharacter.instance.transform.position;
            Vector3 agentPosition = controller.transform.position;

            Vector3 moveDirection = playerPosition - agentPosition;

            rb2d.velocity = moveDirection.normalized * data.moveSpeed;
        }
    }
}
