using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public PlayerScript s;
    public GameObject Panel;

    public void MenuButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void RestartButton()
    {
        PlayerScript.IsPaused = false;
        SceneManager.LoadScene("GameScene");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Hindernis")
        {
            Panel.SetActive(true);
            PlayerScript.IsPaused = true;
            s.speed = 0;           

            
        }
    }
}
