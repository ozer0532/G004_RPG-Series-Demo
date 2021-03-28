using UnityEngine;

[CreateAssetMenu(fileName = "New Achievement", menuName = "Achievement")]
public class AchievementData : ScriptableObject
{
    public Statistics stat;
    public int threshold;

	public string label;
	public string description;

	private bool achievementGot;

	private void OnEnable()
	{
		if (stat != null)
        {
			stat.OnValueChanged += CheckAchievement;

			// Resets the value
			achievementGot = false;
		}
	}

	private void OnDisable()
	{
		if (stat != null)
			stat.OnValueChanged -= CheckAchievement;
	}

	private void CheckAchievement(int value)
    {
		if (!achievementGot)
        {
			if (value >= threshold)
            {
				achievementGot = true;
				AchiementManager.instance.OnAchiementGet(this);
            }
        }
    }
}