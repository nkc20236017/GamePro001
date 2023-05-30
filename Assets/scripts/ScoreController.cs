using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text text;
    GameObject distance;
    GameObject director;
    public int a = 0;
    void Start()
    {
        this.distance = GameObject.Find("GameScore");
        this.director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        if (director.GetComponent<GameDirector>().Judge)
        {
            a++;
        }
        text.text = a.ToString("D6") + "km";
    }
}
