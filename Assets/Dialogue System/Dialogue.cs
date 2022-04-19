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
<<<<<<< HEAD
    public string[] options;
    public bool stay;

=======
    
>>>>>>> parent of 868b76f (Add files via upload)
    public Dialogue[] getNext()
    {
        return this.next;
    }
<<<<<<< HEAD
    public string[] getOptions()
    {
        return this.options;
    }
=======
>>>>>>> parent of 868b76f (Add files via upload)
}
