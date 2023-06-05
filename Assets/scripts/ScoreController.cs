using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ScoreController : MonoBehaviour
{
    public Text text;
    GameObject distance;
    GameObject director;
    public int a = 0;
    int b = 2000;
    public bool bosEvent=false;
    void Start()
    {
        this.distance = GameObject.Find("GameScore");
        this.director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        text.text = a.ToString("D7")+"P";
        if (a>=b && bosEvent == false)
        {
                b += 10000;
            director.GetComponent<GameDirector>().BosEvent();
            bosEvent = true;
        }
    }
    public void AddPoint()
    {
        if (director.GetComponent<GameDirector>().Judge)
        {
            if (GameDirector2.mode == 2)
            {
                a += 100;
            }
            else
            {
                a += 50;
            }
        }
    }
    public void AddPoint2()
    {
        if (director.GetComponent<GameDirector>().Judge)
        {
            if (GameDirector2.mode == 2)
            {
                a += 2000;
            }
            else
            {
                a += 1000;
            }
        }
    }
}
