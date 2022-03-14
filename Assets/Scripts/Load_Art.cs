using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Art : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.UnloadScene("SampleScene");
        //SceneManager.LoadScene("NFT");

        SceneManager.LoadScene("Stage 1");
    }

    // Update is called once per frame
    void Update()
    {
        //SceneManager.UnloadScene("NFT");
        //SceneManager.LoadScene("SampleScene");
        
        
    }
}
