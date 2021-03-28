using UnityEngine;

public class AutoDialogTrigger : MonoBehaviour
{
    public Conversation conv;

    private void OnEnable()
    {
        DialogManager.instance.StartConversation(conv);
        TimelineManager.instance.PauseTimeline();
    }
}
