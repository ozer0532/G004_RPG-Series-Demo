using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    // Singleton instance of the TimelineManager
    public static TimelineManager instance;

    public PlayableDirector director;

    void Awake()
    {
        // Initialize singleton instance
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void PauseTimeline()
    {
        director.playableGraph.GetRootPlayable(0).SetSpeed(0);
    }

    public void ResumeTimeline()
    {
        director.playableGraph.GetRootPlayable(0).SetSpeed(1);
    }
}
