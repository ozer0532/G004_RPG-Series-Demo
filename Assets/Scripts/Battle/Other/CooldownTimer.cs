using UnityEngine;

public class CooldownTimer : MonoBehaviour
{
    public float duration;
    public int stocks = 1;

    private SkillUsageBase usage;
    private int currentStocks;

    private void Awake()
    {
        usage = GetComponent<SkillUsageBase>();
        currentStocks = stocks;
    }

    private void OnSkillUse()
    {
        if (usage && currentStocks > 0)
        {
            currentStocks--;
            if (currentStocks <= 0)
            {
                usage.enabled = false;
            }
            if (!IsInvoking("CooldownOver"))
            {
                Invoke("CooldownOver", duration);
            }
        }
    }

    private void CooldownOver()
    {
        usage.enabled = true;
        currentStocks++;
        if (currentStocks != stocks)
        {
            Invoke("CooldownOver", duration);
        }
    }
}
