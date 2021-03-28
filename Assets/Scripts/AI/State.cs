using UnityEngine;

[CreateAssetMenu(fileName = "New State", menuName = "AI/State")]
public class State : ScriptableObject
{
    public ActionBase[] actions;
    public Transition[] transitions;

    public void UpdateState(StateController controller)
    {
        DoActions(controller);
        CheckTransitions(controller);
    }

    private void DoActions(StateController controller)
    {
        foreach (ActionBase action in actions)
        {
            action.RunAction(controller);
        }
    }

    private void CheckTransitions(StateController controller)
    {
        foreach (Transition transition in transitions)
        {
            bool conditionMet = transition.condition.IsConditionMet(controller);
            if (conditionMet != transition.changeWhenFalse)
            {
                controller.DoTransition(transition.targetState);
                return;
            }
        }
    }
}
