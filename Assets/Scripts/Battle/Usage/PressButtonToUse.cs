using UnityEngine;

public class PressButtonToUse : SkillUsageBase
{
    public string button = "Fire1";

    private void Update()
    {
        if (Input.GetButtonDown(button))
        {
            gameObject.SendMessage("OnSkillUse");
        }
    }
}
