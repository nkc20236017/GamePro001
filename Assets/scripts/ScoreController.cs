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
        if (a>=b)
        {
            if (b<=27000)
            {
                b += 7500;
            }
            else
            {
                b += 15000;
            }
            director.GetComponent<GameDirector>().BosEvent();
            bosEvent = true;
        }
    }
    public void AddPoint()
    {
        if (director.GetComponent<GameDirector>().Judge)
        {
            a += 100;
        }
    }
    public void AddPoint2()
    {
        if (director.GetComponent<GameDirector>().Judge)
        {
            a += 2000;
        }
    }
}
