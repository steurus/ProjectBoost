using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApllication : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("we pushed escape");
            Application.Quit();
        }
    }
}
