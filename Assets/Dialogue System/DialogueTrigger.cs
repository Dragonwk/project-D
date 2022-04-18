using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().OptionDialogue(dialogue.next);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    
    }
    public void setDialogue(Dialogue d)
    {
        this.dialogue = d;
    }
}
