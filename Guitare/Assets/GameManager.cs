using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    int multiplier = 2;
    int streak = 0;
    int streak_max = 0;
    int life = 50;
    public GameObject Win;
    public VideoPlayer Vp;
    public GameObject Note;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("Streak", 0);
        PlayerPrefs.SetInt("StreakMax", 0);
        PlayerPrefs.SetInt("Mult", 1);
        PlayerPrefs.SetInt("RockMeter", -32);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Destroy(col.gameObject);
    }

    public void AddStreak()
    {
        if (life < 50)
            life++;
        //if (PlayerPrefs.GetInt("RockMeter")+1 <-27)
        
            //PlayerPrefs.SetInt("RockMetter", PlayerPrefs.GetInt("RockMeter")+1);
        streak++;
        if (streak > streak_max)
            streak_max = streak;
        if (streak >= 24)
            multiplier = 4;
        else if (streak >= 16)
            multiplier = 3;
        else if (streak >= 8)
            multiplier = 2;
        else
            multiplier = 1;
        UpdateGUI();
    }

    public void ResetStreak()
    {
        life -= 2;
        if (life < 0)
        {
            Note.SetActive(false);
            Win.SetActive(true);
            Vp.Pause();
        }

        //PlayerPrefs.SetInt("RockMetter", PlayerPrefs.GetInt("RockMeter") -2);
        //if (PlayerPrefs.GetInt("RockMeter") > -36)
        //    Application.Quit();
        streak = 0;
        multiplier = 1;
        UpdateGUI();
    }

    void UpdateGUI()
    {
        PlayerPrefs.SetInt("Streak", streak);
        PlayerPrefs.SetInt("Mult", multiplier);
        PlayerPrefs.SetInt("StreakMax", streak_max);
    }

    public int GetScore()
    {
        return 100 * multiplier;
    }
}
