using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    GameObject distance;
    int a = 0;
    void Start()
    {
        this.distance = GameObject.Find("GameScore");
    }

    void Update()
    {
        a++;
        this.distance.GetComponent<TextMeshProUGUI>().text =
            a.ToString("D6") + "km";
    }
}
