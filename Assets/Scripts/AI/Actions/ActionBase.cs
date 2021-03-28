using UnityEngine;

public abstract class ActionBase : ScriptableObject
{
    public abstract void RunAction(StateController controller);
}
