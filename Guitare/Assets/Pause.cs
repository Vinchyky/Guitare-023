using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public string levelToLoad;
    public GameObject PauseWindow;
    public bool statuspause;

    public void SetPause()
    {
        if (statuspause == true)
            statuspause = false;
        else
            statuspause = true;
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
