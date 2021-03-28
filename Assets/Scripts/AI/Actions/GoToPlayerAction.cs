using UnityEngine;

[CreateAssetMenu(fileName = "Go to Player Action", menuName = "AI/Actions/Go to Player")]
public class GoToPlayerAction : ActionBase
{
    public override void RunAction(StateController controller)
    {
        if (TopdownCharacter.instance)
        {
            Rigidbody2D rb2d = controller.GetComponent<Rigidbody2D>();
            AIMovementData data = controller.GetComponent<AIMovementData>();
            if (rb2d && data)
            {
                // Get stored information

                Vector2 moveDirection = TopdownCharacter.instance.transform.position - controller.transform.position;

                rb2d.velocity = moveDirection.normalized * data.moveSpeed;

                // Animation specific functions
                AIAnimationData anim = controller.GetComponent<AIAnimationData>();
                if (anim)
                {
                    anim.PlayAnimation("Move", moveDirection);
                }
            }
            else
            {
                Debug.LogWarning("AI Agent requires Rigidbody2D and AIMovementData components to work.");
            }
        }
    }
}
