using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject DBox;
    public GameObject TButton;
    public GameObject O1;
    public GameObject O2;
    public GameObject O3;
    public GameObject O4;
    // Start is called before the first frame update
    public void OpenPanel()
    {

        if(DBox != null)
        {
            bool isActive = DBox.activeSelf;
            TButton.SetActive(!isActive);
            O1.SetActive(!isActive);
            O2.SetActive(!isActive);
            O3.SetActive(!isActive);
            O4.SetActive(!isActive);
            DBox.SetActive(!isActive);
        }
    }

}
