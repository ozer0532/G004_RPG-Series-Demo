using UnityEngine;

public class PressKeyToUse : SkillUsageBase
{
    public KeyCode key;

    private void Update()
    {
        if (Input.GetKeyDown(key))
        {
            gameObject.SendMessage("OnSkillUse");
        }
    }
}
