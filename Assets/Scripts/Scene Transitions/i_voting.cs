using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class i_voting : MonoBehaviour
{

    public GameObject vote;

    private void Start()
    {

        vote.transform.hasChanged = false;

    }
    private void Update()
    {

        // Load - Art stage 2
        if(vote.transform.hasChanged == true)
        {
            SceneManager.LoadScene("Voting_stage6");
            SceneManager.UnloadScene("Main_stage1");
            //SceneManager.UnloadSceneAsync("Main_stage1");


            vote.transform.hasChanged = false;

        }

    }


  
}
