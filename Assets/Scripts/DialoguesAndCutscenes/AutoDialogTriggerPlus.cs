using UnityEngine;

public class AutoDialogTriggerPlus : MonoBehaviour
{
    public ConversationPlus conv;

    private void OnEnable()
    {
        DialogManagerPlus.instance.StartConversation(conv);
        TimelineManager.instance.PauseTimeline();
    }
}
