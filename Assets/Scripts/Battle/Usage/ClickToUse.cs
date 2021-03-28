using UnityEngine;

public class ClickToUse : SkillUsageBase
{
    public int mouseButton = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(mouseButton))
        {
            gameObject.SendMessage("OnSkillUse");
        }
    }
}
