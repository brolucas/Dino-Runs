using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseUI;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pauseUI.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                pauseUI.SetActive(true);
            }
            
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(false);
    }
}
