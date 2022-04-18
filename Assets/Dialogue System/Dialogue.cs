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
    
    public Dialogue[] getNext()
    {
        return this.next;
    }
}
