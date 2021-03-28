﻿using UnityEngine;

[CreateAssetMenu(fileName = "Strafe Around Player Action", menuName = "AI/Actions/Strafe Around Player")]
public class StrafeAroundPlayerAction : ActionBase
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

                Vector2 playerDirection = TopdownCharacter.instance.transform.position - controller.transform.position;
                Vector2 moveDirection = Quaternion.Euler(0, 0, 90) * playerDirection;

                rb2d.velocity = moveDirection.normalized * data.moveSpeed;

                // Animation specific functions
                AIAnimationData anim = controller.GetComponent<AIAnimationData>();
                if (anim)
                {
                    anim.PlayAnimation("Move", playerDirection);
                }
            }
            else
            {
                Debug.LogWarning("AI Agent requires Rigidbody2D and AIMovementData components to work.");
            }
        }
    }
}
