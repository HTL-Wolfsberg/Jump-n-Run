using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hindernis")
        {
            
        }
    }
}
