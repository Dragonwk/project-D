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
    public PanelOpener panel;
    //public Animator animator;
    public bool Close;
    public bool modelActive;
    public GameObject model;

    void Start()
    {
        sentences = new Queue<string>();
        modelActive = false;
    }

    public void StartDialogue(Dialogue dialogue,bool close)
    {
        Debug.Log("Starting conversation with " + dialogue.name);
        panel.OpenAll();
        //Debug.Log(nameText.text);
        Close = close;
       //animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;
        //Debug.Log(dialogue.sentences);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }
        DisplayNextSentence();
        if (start.dialogue.model != null)
        {
            if (modelActive == false)
            {
                modelActive = true;
                model = start.dialogue.model;
                model.SetActive(true);
                //start.dialogue.model.setActive(true);
            }
            else
            {
                model.SetActive(false);
                model = start.dialogue.model;
                model.SetActive(true);
            }
            
        }
            
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
            //animator.SetBool("IsOpen", false);
            //FindObjectOfType<Canvas>().enabled = false;
            panel.CloseAll();
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
        panel.OpenAll();
        
        for (int i=0; i < 4; i++)
        {
            options[i].setDialogue(next[i]);
            optionNames[i].text = option[i];
            if (next[i].empty == true)
            {
                if (i == 0)
                    panel.CloseO1();
                else if (i == 1)
                    panel.CloseO2();
                else if (i == 2)
                    panel.CloseO3();
                else
                    panel.CloseO4();
            }
        }
/*
        foreach(DialogueTrigger d in options)
        {
            d.setDialogue(next[i]);
            optionNames[i].text = option[i];
            i++;
            if (next[i].empty == true )
            {
                if (i == 0)
                    panel.CloseO1();
                else if (i == 1)
                    panel.CloseO2();
                else if (i == 2)
                    panel.CloseO3();
                else
                    panel.CloseO4();
            }
        }*/
    }

}
