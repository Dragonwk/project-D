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

    public void CloseO1()
    {
        O1.SetActive(false);
    }
    public void CloseO2()
    {
        O2.SetActive(false);
    }
    public void CloseO3()
    {
        O3.SetActive(false);
    }
    public void CloseO4()
    {
        O4.SetActive(false);
    }
    public void OpenAll()
    {
        if (DBox != null)
        {
            O1.SetActive(true);
            O2.SetActive(true);
            O3.SetActive(true);
            O4.SetActive(true);
            TButton.SetActive(true);
            DBox.SetActive(true);
        }
    }
    public void CloseAll()
    {
        if (DBox != null)
        {
            O1.SetActive(false);
            O2.SetActive(false);
            O3.SetActive(false);
            O4.SetActive(false);
            TButton.SetActive(false);
            DBox.SetActive(false);
        }
    }

}
