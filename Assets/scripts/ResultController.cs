using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultController : MonoBehaviour
{
    public int score = 0;
    public int highscore = 0;
    public Text text;
    public Text text2;
    public Text text3;
    GameObject distance;
    void Start()
    {
        this.distance = GameObject.Find("GameDirector");
        score = this.distance.GetComponent<ScoreController>().a;
        highscore = PlayerPrefs.GetInt("SCORE",0);
        if (highscore<score)
        {
            highscore = score;
            PlayerPrefs.SetInt("SCORE", highscore);
            PlayerPrefs.Save();
        }
    }

    void Update()
    {
        text.text = "リザルト\n\n"+score.ToString( ) + "P";
        text2.text = "ハイスコア\n\n" + highscore.ToString() + "P";
        text3.text = "タイトルに戻る";
    }
}
