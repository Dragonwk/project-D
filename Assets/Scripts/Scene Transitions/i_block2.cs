using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class i_block2 : MonoBehaviour
{

    public GameObject block2;
    public GameObject ledgers;


    private void Start()
    {

        block2.transform.hasChanged = false;
    }
    private void Update()
    {

        // Load - Ledger stage 3
        if (block2.transform.hasChanged == true)
        {
            //SceneManager.LoadScene("Ledger_stage3.1");
            //SceneManager.UnloadScene("Art_stage2");
            bool isActive = block2.activeSelf;

            block2.SetActive(!isActive);
            ledgers.SetActive(isActive);

            block2.transform.hasChanged = false;

        }




    }



}
