using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorial {
    [CreateAssetMenu(fileName = "New Achievement ttr", menuName = "Acheievement 4 tutor")]
    public class AchievementData : ScriptableObject
    {
        public Statistics stat;
        public int threshold;

        public string label;
        public string description;

        private bool achievementGot;

        private void OnEnable()
        {
            if (stat)
            {
                stat.onValueChanged += CheckAchievement;

                achievementGot = false;
            }
        }

        private void OnDisable()
        {
            if (stat)
            {
                stat.onValueChanged -= CheckAchievement;
            }
        }

        private void CheckAchievement(int value)
        {
            if (!achievementGot)
            {
                if (value >= threshold)
                {
                    achievementGot = true;
                    AchievementManager.instance?.OnAchievementGet(this);
                }
            }
        }
    }
}