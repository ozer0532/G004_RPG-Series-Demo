using UnityEngine;

[System.Serializable]
public class DialogPlus
{
    public Character character;

    [TextArea(3, 10)]
    public string sentence;
}
