using UnityEngine;

public abstract class ConditionBase2 : ScriptableObject
{
    public abstract bool CheckCondition(StateController2 controller);
}
