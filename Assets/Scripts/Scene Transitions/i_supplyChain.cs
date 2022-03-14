using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class i_supplyChain : MonoBehaviour
{

    public GameObject supplyChain;

    private void Start()
    {

        supplyChain.transform.hasChanged = false;

    }
    private void Update()
    {

        // Load - Art stage 2
        if(supplyChain.transform.hasChanged == true)
        {
            SceneManager.LoadScene("SupplyChain_stage5");
            SceneManager.UnloadScene("Main_stage1");
            //SceneManager.UnloadSceneAsync("Main_stage1");


            supplyChain.transform.hasChanged = false;

        }

    }


  
}
