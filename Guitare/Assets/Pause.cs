using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Pause : MonoBehaviour
{
    public string levelToLoad;
    public string reload;
    public GameObject PauseWindow;
    public bool statuspause;
    public bool isPaused;
    public VideoPlayer Vp;

    public void SetPause()
    {
        if (statuspause == true) {
            isPaused = false;
            statuspause = false;
            Vp.Play();
        }
        else {
            statuspause = true;
            isPaused = true;
            Vp.Pause();
        }
        PauseWindow.SetActive(statuspause);
    }

    public void Update()
    {
        if (isPaused)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f;
    }

    public void ReturnGame()
    {
        if (statuspause == true)
        {
            isPaused = false;
            statuspause = false;
            Vp.Play();
        }
        else
        {
            statuspause = true;
            isPaused = true;
            Vp.Pause();
        }
        PauseWindow.SetActive(false);

    }
    
    public void Reload()
    {
        SceneManager.LoadScene(reload);
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
