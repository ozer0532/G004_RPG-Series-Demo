﻿using UnityEngine;

public abstract class ConditionBase : ScriptableObject
{
    public abstract bool IsConditionMet(StateController controller);
}
