using UnityEngine;

[CreateAssetMenu(fileName = "Shoot Action", menuName = "AI/Actions/Shoot")]
public class ShootAction : ActionBase
{
    public override void RunAction(StateController controller)
    {
        if (TopdownCharacter.instance && controller.skill)
        {
            controller.skill.GetComponent<InvokeToUse>().Invoke();
        }
    }
}
