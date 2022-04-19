using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
<<<<<<< HEAD
        FindObjectOfType<DialogueManager>().OptionDialogue(dialogue.next,dialogue.options, dialogue);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        //FindObjectOfType<DialogueManager>().setStart(dialogue);
=======
        FindObjectOfType<DialogueManager>().OptionDialogue(dialogue.next);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    
>>>>>>> parent of 868b76f (Add files via upload)
    }
    public void setDialogue(Dialogue d)
    {
        this.dialogue = d;
    }
}
