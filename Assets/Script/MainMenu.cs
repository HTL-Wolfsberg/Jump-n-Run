using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text highscoreText;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerScript.IsPaused = false;
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    private void Start()
    {
        highscoreText.text = "Highscore: "+ PlayerPrefs.GetFloat(Score.higscoreTextKey)+" Points".ToString();
    }
}