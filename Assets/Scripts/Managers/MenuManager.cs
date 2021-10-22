using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance { get; private set; }

    private void Start()
    {
        Instance = this;
    }


    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main menu");
    }

    public void LoadSameScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
}
