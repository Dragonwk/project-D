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

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);
        Debug.Log(nameText.text);
        nameText.text = dialogue.name;
        Debug.Log(dialogue.sentences);
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
        DialogueText.text = sentence;

    }

    void EndDialogue()
    {
        Debug.Log("End of conversation.");
    }
    
    public void OptionDialogue(Dialogue[] option)
    {
        int i = 0;
        foreach(DialogueTrigger d in options)
        {
            d.setDialogue(option[i]);
            i++;
        }
    }
}
