using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue : MonoBehaviour
{
    public string name;
    [TextArea(3,10)]
    public string[] sentences;
    public Dialogue[] next;
    public string[] options;
    public bool stay;
    public bool close;
    public bool item;
    public spawn spawner;

    public Dialogue[] getNext()
    {
        return this.next;
    }
    public string[] getOptions()
    {
        return this.options;
    }

}
