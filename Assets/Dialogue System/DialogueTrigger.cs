using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().OptionDialogue(dialogue.next,dialogue.options, dialogue);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

    
    }
    public void setDialogue(Dialogue d)
    {
        this.dialogue = d;
    }
}
