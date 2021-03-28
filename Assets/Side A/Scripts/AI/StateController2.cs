using UnityEngine;

public class StateController2 : MonoBehaviour
{
    public State2 currentState;

    private void FixedUpdate()
    {
        currentState.UpdateState(this);
    }

    public void DoTransition(State2 state)
    {
        currentState = state;
    }
}
