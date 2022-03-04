using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    //Score
    //public float counter = 0.001f;
    public float score;
    public float Highscore;

    float scorespeed = 0.010f;
    public Text distancemoved;
    float distanceunit = 0;
    public Rigidbody rigid;

    //public Text scoretext;
    public Text highscoretext;

    //public void AddScore()
    //{
    //    score++;
    //}

    string higscoreTextKey = "Highscore";

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        Highscore = PlayerPrefs.GetFloat(higscoreTextKey);
    }

    // Update is called once per frame
    void Update()
    {
        //scoretext.text = score.ToString();
        highscoretext.text = "Highscore: " +  Highscore.ToString();
        if (distanceunit > Highscore)
        {
            PlayerPrefs.SetFloat(higscoreTextKey, Mathf.RoundToInt(distanceunit));
        }
        distance();
    }

    //Score
    void distance()
    {
        distanceunit = distanceunit + scorespeed;
        distancemoved.text = "Points: " + Mathf.RoundToInt(distanceunit).ToString();
    }
}
