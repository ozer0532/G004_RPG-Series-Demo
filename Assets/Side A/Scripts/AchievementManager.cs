using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorial
{
    public class AchievementManager : MonoBehaviour
    {
        public static AchievementManager instance;

        private void Awake()
        {
            if (instance)
            {
                Destroy(gameObject);
            }
            else
            {
                instance = this;
            }
        }

        public void OnAchievementGet(AchievementData achievement)
        {
            print("Achievement get: " + achievement.label + " - " + achievement.description);
        }
    }
}
