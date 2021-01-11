using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Character", menuName = "RPGSeries/Dialog Character")]
public class Character : ScriptableObject
{
    public string characterName;
    public Sprite dialogBox;
}
