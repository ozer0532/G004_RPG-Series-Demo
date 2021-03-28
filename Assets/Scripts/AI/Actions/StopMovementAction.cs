using UnityEngine;

[CreateAssetMenu(fileName = "Stop Movement Action", menuName = "AI/Actions/Stop Movement")]
public class StopMovementAction : ActionBase
{
    public override void RunAction(StateController controller)
    {
        Rigidbody2D rb2d = controller.GetComponent<Rigidbody2D>();
        if (rb2d)
        {
            rb2d.velocity = Vector2.zero;

            // Animation specific functions
            AIAnimationData anim = controller.GetComponent<AIAnimationData>();
            if (anim)
            {
                anim.PlayAnimation("Idle");
            }
        }
        else
        {
            Debug.LogWarning("AI Agent requires Rigidbody2D component to work.");
        }
    }
}
