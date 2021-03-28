using UnityEngine;

public class AchiementManager : MonoBehaviour
{
    public static AchiementManager instance;
    
    void Awake()
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

    public void OnAchiementGet(AchievementData achievement)
    {
        print("Achievement get: " + achievement.label + " - " + achievement.description);
    }
}
