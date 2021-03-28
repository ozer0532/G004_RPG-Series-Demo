using UnityEngine;

public class PressKeyToUse2 : SkillUsageBase2
{
    public KeyCode key;

    private void Update()
    {
        if (Input.GetKeyDown(key))
        {
            SendMessage("OnSkillUse");
        }
    }
}
