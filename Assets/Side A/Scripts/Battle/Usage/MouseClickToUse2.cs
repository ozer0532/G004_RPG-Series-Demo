using UnityEngine;

public class MouseClickToUse2 : SkillUsageBase2
{
    public int mouseButton; // 0 = left click; 1 = right click; 2 = middle click

    private void Update()
    {
        if (Input.GetMouseButtonDown(mouseButton))
        {
            SendMessage("OnSkillUse");
        }
    }
}
