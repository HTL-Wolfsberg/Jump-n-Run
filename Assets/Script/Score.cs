using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    //Score
    //public float counter = 0.001f;
    public float Highscore;

    public float scorespeed = 0.009f;
    public Text distancemoved;
    float distanceunit = 0;
    public Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        InvokeRepeating("distance", 0, 1/scorespeed);
    }

    // Update is called once per frame
    void Update()
    {
        distance();

    }
    //Score
    void distance()
    {

        distanceunit = distanceunit + scorespeed;
        distancemoved.text = "Points: " + Mathf.RoundToInt(distanceunit).ToString();
    }
}
