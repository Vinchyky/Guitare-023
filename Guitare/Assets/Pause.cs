using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public string levelToLoad;
    public GameObject PauseWindow;
    public bool statuspause;
    public bool isPaused;

    public void SetPause()
    {
        if (statuspause == true) {
            isPaused = false;
            statuspause = false;
        }
        else {
            statuspause = true;
            isPaused = true;
        }
        PauseWindow.SetActive(statuspause);
    }

    public void ReturnGame()
    {
        PauseWindow.SetActive(false);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
