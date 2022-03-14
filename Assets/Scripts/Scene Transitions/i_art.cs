using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class i_art : MonoBehaviour
{

    public GameObject art;

    private void Start()
    {

        art.transform.hasChanged = false;

    }
    private void Update()
    {

        // Load - Art stage 2
        if(art.transform.hasChanged == true)
        {
            SceneManager.LoadScene("Art_stage2");
            SceneManager.UnloadScene("Main_stage1");
            //SceneManager.UnloadSceneAsync("Main_stage1");
            
            
            art.transform.hasChanged = false;

        }

    }


  
}
