using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Tutorial
{
    [CreateAssetMenu(fileName = "New Statistic 4 tutor", menuName = "Statistic 4 tutor")]
    public class Statistics : ScriptableObject
    {
        public static Dictionary<string, int> stats = new Dictionary<string, int>();

        public string statName;

        public UnityAction<int> onValueChanged;

        public void SetValue(int value)
        {
            if (stats.ContainsKey(statName))
            {
                stats[statName] = value;
            }
            else
            {
                stats.Add(statName, value);
            }
            if (onValueChanged != null) onValueChanged.Invoke(value);
        }

        public void AddValue(int value = 1)
        {
            if (stats.ContainsKey(statName))
            {
                stats[statName] += value;
            }
            else
            {
                stats.Add(statName, value);
            }
            if (onValueChanged != null) onValueChanged.Invoke(stats[statName]);
        }
    }
}
