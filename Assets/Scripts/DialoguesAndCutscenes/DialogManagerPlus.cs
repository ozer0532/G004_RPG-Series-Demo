using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManagerPlus : MonoBehaviour
{
    // Singleton instance of the DialogManager
    public static DialogManagerPlus instance;

    public ConversationPlus currentConversation;
    public Queue<DialogPlus> currentDialogs = new Queue<DialogPlus>();

    public TMP_Text nameDisplay;
    public TMP_Text sentenceDisplay;
    public Image dialogBox;

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

    public void StartConversation(ConversationPlus conv)
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
            DialogPlus dialog = currentDialogs.Dequeue();
            nameDisplay.text = dialog.character.characterName;
            sentenceDisplay.text = dialog.sentence;
            dialogBox.sprite = dialog.character.dialogBox;
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
