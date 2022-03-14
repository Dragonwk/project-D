using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transactionsGeneral : MonoBehaviour
{

    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenPanel()
    {
        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
}
