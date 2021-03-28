using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Statistic", menuName = "Statistic")]
public class Statistics : ScriptableObject
{
    public static Dictionary<string, int> stats = new Dictionary<string, int>();

    public string statName;
    public UnityAction<int> OnValueChanged;

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
        if (OnValueChanged != null) OnValueChanged.Invoke(value);
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
        if (OnValueChanged != null) OnValueChanged.Invoke(stats[statName]);
    }
}
