using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    // Singleton instance of the DialogManager
    public static DialogManager instance;

    public Conversation currentConversation;
    public Queue<Dialog> currentDialogs = new Queue<Dialog>();

    public TMP_Text nameDisplay;
    public TMP_Text sentenceDisplay;

    public Animator dialogBoxAnimator;

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

    private void Start()
    {
        nameDisplay.text = "";
        sentenceDisplay.text = "";
    }

    public void StartConversation(Conversation conv)
    {
        currentDialogs.Clear();                 // Stops the ongoing conversation if any
        currentConversation = conv;

        for (int i = 0; i < currentConversation.dialogs.Length; i++)
        {
            currentDialogs.Enqueue(currentConversation.dialogs[i]);
        }

        dialogBoxAnimator.Play("DialogUI_SlideIn");
        NextDialog();
    }

    public void NextDialog()
    {
        if (currentDialogs.Count != 0)
        {
            Dialog dialog = currentDialogs.Dequeue();
            nameDisplay.text = dialog.name;
            sentenceDisplay.text = dialog.sentence;
        }
        else
        {
            dialogBoxAnimator.Play("DialogUI_SlideOut");
            if (!TimelineManager.instance.director.playableGraph.IsDone())
            {
                TimelineManager.instance.ResumeTimeline();
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextDialog();
        }
    }
}
