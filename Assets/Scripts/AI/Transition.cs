[System.Serializable]
public class Transition
{
    public ConditionBase condition;
    public bool changeWhenFalse;
    public State targetState;
}
