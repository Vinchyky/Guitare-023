using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int multiplier = 2;
    int streak = 0;
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("Streak", 0);
        PlayerPrefs.SetInt("Mult", 1);
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Escape))
                isPaused = !isPaused;

            if (isPaused)
                Time.timeScale = 0f;
            else
                Time.timeScale = 1f;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
    }

    public void AddStreak()
    {
        streak++;
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
        print("test\n");
        streak = 0;
        multiplier = 1;
        UpdateGUI();
    }

    void UpdateGUI()
    {
        PlayerPrefs.SetInt("Streak", streak);
        PlayerPrefs.SetInt("Mult", multiplier);
    }

    public int GetScore()
    {
        return 100 * multiplier;
    }
}
