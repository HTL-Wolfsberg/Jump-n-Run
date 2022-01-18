using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public PlayerScript s;
    public GameObject pauseMenuUI;

    float temp;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
  
            }

        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        s.speed = temp;
    }
    void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        temp = s.speed;
        //Debug.Log(temp);
        s.speed = 0;
    }
    public void LoadMenu()
    {
        Debug.Log("Loading menu ....");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game ....");
        Application.Quit();
    }
}
