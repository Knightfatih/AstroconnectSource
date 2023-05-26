using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private void Start()
    {
        AudioListener.volume = 0.1f;
    }

    public void LoadScene (string s)
        {
            SceneManager.LoadScene(s);
            Time.timeScale = 1f;
        }
 public void ExitGame()
    {
        Application.Quit();
    }
}