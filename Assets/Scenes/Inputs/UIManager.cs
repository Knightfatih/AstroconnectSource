using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static bool Paused;
    public GameObject PausePanel; //nextlevelPanel

    public void NPaused()
    {
        Paused = false;
        Time.timeScale = 1f;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Paused = !Paused;
            if (Paused)
            {
                PausePanel.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                PausePanel.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
}
