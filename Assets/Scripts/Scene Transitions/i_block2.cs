using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class i_block2 : MonoBehaviour
{

    public GameObject block1;

    private void Start()
    {

        block1.transform.hasChanged = false;
    }
    private void Update()
    {

        // Load - Ledger stage 3
        if (block1.transform.hasChanged == true)
        {
            SceneManager.LoadScene("Ledger_stage3.1");
            SceneManager.UnloadScene("Art_stage2");

            block1.transform.hasChanged = false;

        }




    }



}
