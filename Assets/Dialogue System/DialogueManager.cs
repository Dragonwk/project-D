using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text DialogueText;
    private Queue<string> sentences;
    public DialogueTrigger[] options;
    public Text[] optionNames;
    public DialogueTrigger start;

    public Animator animator;
    public bool Close;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue,bool close)
    {
        Debug.Log("Starting conversation with " + dialogue.name);
        //Debug.Log(nameText.text);
        Close = close;
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;
        //Debug.Log(dialogue.sentences);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }

    IEnumerator TypeSentence(string str)
    {
        DialogueText.text = "";
        foreach(char letter in str.ToCharArray())
        {
            DialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        if (Close == true)
        {
            animator.SetBool("IsOpen", false);
        }
        //animator.SetBool("IsOpen", false);
        Debug.Log("End of conversation.");
    }
    
    public void OptionDialogue(Dialogue[] next, string[] option , Dialogue di)
    {
        if (di.stay == true)
        {
            start.dialogue = di;
        }
        int i = 0;
        foreach(DialogueTrigger d in options)
        {
            d.setDialogue(next[i]);
            optionNames[i].text = option[i];
            i++;
        }
    }

}
