public class InvokeToUse : SkillUsageBase
{
    public void Invoke()
    {
        if (enabled)
        {
            gameObject.SendMessage("OnSkillUse");
        }
    }
}
