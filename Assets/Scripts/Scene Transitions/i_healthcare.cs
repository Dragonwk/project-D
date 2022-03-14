using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class i_healthcare : MonoBehaviour
{

    public GameObject healthcare;

    private void Start()
    {

        healthcare.transform.hasChanged = false;

    }
    private void Update()
    {

        // Load - Art stage 2
        if(healthcare.transform.hasChanged == true)
        {
            SceneManager.LoadScene("Healthcare_stage7");
            SceneManager.UnloadScene("Main_stage1");
            //SceneManager.UnloadSceneAsync("Main_stage1");


            healthcare.transform.hasChanged = false;

        }

    }


  
}
