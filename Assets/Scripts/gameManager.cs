using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public Health Tank;
    public Health Tank2;


    void Update()
    {
        if (Tank.hp == 0 || Tank2.hp == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
