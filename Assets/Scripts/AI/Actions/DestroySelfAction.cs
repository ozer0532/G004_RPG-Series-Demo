using UnityEngine;

[CreateAssetMenu(fileName = "Destroy Self Action", menuName = "AI/Actions/Destroy Self")]
public class DestroySelfAction : ActionBase
{
    public override void RunAction(StateController controller)
    {
        Destroy(controller.gameObject);
    }
}
