using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class i_back_toStage1 : MonoBehaviour
{

    public GameObject back;

    private void Start()
    {

        back.transform.hasChanged = false;

    }
    private void Update()
    {

        // Load - Ledger stage 3
        if (back.transform.hasChanged == true)
        {
            SceneManager.LoadScene("Main_stage1");
            SceneManager.UnloadScene("Art_stage2");

            back.transform.hasChanged = false;

        }




    }



}
