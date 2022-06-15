using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class i_demo : MonoBehaviour
{
    public void StartBtn() {
        SceneManager.LoadScene("Demo_stage");
    }
}
