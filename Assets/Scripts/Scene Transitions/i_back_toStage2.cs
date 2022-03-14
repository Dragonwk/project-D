using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class i_back_toStage2 : MonoBehaviour
{

    public GameObject back;

    private void Start()
    {

       // Debug.Log("Made it! -> Stage 2");

        back.transform.hasChanged = false;

    }
    private void Update()
    {

        // Load - Ledger stage 3
        if (back.transform.hasChanged == true)
        {
            SceneManager.LoadScene("Art_stage2");
            SceneManager.UnloadScene("Ledger_stage3");

            back.transform.hasChanged = false;
         
        }




    }



}
