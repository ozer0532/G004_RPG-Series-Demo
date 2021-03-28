using UnityEngine;

public class StateController : MonoBehaviour
{
    public State currentState;

    [Header("References")]
    public SkillController skill;

    private void FixedUpdate()
    {
        currentState.UpdateState(this);
    }

    public void DoTransition(State state)
    {
        currentState = state;
    }
}
