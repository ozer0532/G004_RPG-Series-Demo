using UnityEngine;

[CreateAssetMenu(fileName = "Evade Player Action", menuName = "AI/Actions/Evade Player")]
public class EvadePlayerAction : ActionBase
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

                Vector2 moveDirection = controller.transform.position - TopdownCharacter.instance.transform.position;

                rb2d.velocity = moveDirection.normalized * data.moveSpeed;

                // Animation specific functions
                AIAnimationData anim = controller.GetComponent<AIAnimationData>();
                if (anim)
                {
                    anim.PlayAnimation("Move", -moveDirection);
                }
            }
            else
            {
                Debug.LogWarning("AI Agent requires Rigidbody2D and AIMovementData components to work.");
            }
        }
    }
}
