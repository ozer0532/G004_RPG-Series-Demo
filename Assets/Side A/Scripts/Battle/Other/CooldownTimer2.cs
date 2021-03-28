using UnityEngine;

public class CooldownTimer2 : MonoBehaviour
{
    public float duration;

    private SkillUsageBase2 usage;

    private void Awake()
    {
        usage = GetComponent<SkillUsageBase2>();
    }

    private void OnSkillUse()
    {
        if (usage)
        {
            usage.enabled = false;
            Invoke("CooldownOver", duration);
        }
    }

    private void CooldownOver()
    {
        usage.enabled = true;
    }
}
