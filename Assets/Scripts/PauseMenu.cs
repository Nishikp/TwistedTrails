using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PauseMenu : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    { 
        Time.timeScale = 0;
    }

    public void Continue()
    {
        Time.timeScale = 1;
    }
}