using UnityEngine;

[CreateAssetMenu(fileName = "New State", menuName = "AI/State 2")]
public class State2 : ScriptableObject
{
    public ActionBase2[] actions;
    public Transition2[] transitions;

    public void UpdateState(StateController2 controller)
    {
        DoActions(controller);
        CheckTransitions(controller);
    }

    private void DoActions(StateController2 controller)
    {
        foreach (ActionBase2 action in actions)
        {
            action.DoAction(controller);
        }
    }

    private void CheckTransitions(StateController2 controller)
    {
        foreach (Transition2 transition in transitions)
        {
            if (transition.condition.CheckCondition(controller) != transition.changeWhenFalse)
            {
                controller.DoTransition(transition.targetState);
                break;
            }
        }
    }
}
