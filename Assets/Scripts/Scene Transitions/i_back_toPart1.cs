using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class i_back_toPart1 : MonoBehaviour
{

    public GameObject back;
    public GameObject part1;
    public GameObject part2;
    public GameObject block1Part2;

    private void Start()
    {

        back.transform.hasChanged = false;

    }
    private void Update()
    {

        // Load - Ledger stage 3
        if (back.transform.hasChanged == true)
        {
            //SceneManager.LoadScene("Main_stage1");
            //SceneManager.UnloadScene("Art_stage2");


            part1.SetActive(true);
            part2.SetActive(false);
            block1Part2.SetActive(false);

            back.transform.hasChanged = false;

        }




    }



}
