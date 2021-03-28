using UnityEngine;

[CreateAssetMenu(fileName = "Stop Move Action", menuName = "AI/Actions/Stop Move")]
public class StopMoveAction : ActionBase2
{
    public override void DoAction(StateController2 controller)
    {
        Rigidbody2D rb2d = controller.GetComponent<Rigidbody2D>();

        if (rb2d)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
