using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgerPractice : MonoBehaviour
{


    public string objectname;

    public ArrayList objectContents;

    // Start is called before the first frame update
    void Start()
    {
        objectname = "White Cube";

        objectContents = new ArrayList();

        objectContents.Add("Time Stamp");
        objectContents.Add("Source ID");
        objectContents.Add("Destination ID");
        objectContents.Add("Transaction Report");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
