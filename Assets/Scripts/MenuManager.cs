using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public Panel currentPanel = null;

    

    private List<Panel> panelHistory = new List<Panel>();


    private void Start()
    {
        SetupPanels();
    }

    private void SetupPanels()
    {
        Panel[] panels = GetComponentsInChildren<Panel>();

        foreach(Panel panel in panels)
            panel.Setup(this);

        currentPanel.Show();
    }

    private void Update()
    {
        
    }

    public void GoToPrev()
    {

    }

    public void SetCurrentWithHistory(Panel newPanel)
    {

    }

    private void SetCurrent(Panel newPanel)
    {

    }

}
