using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject HpGauge;
    void Start()
    {
        this.HpGauge = GameObject.Find("HpGauge");
    }
    void Update()
    {
        this.HpGauge.GetComponent<Image>().fillAmount -= 0.0001f;
        if (this.HpGauge.GetComponent<Image>().fillAmount<=0)
        {
            SceneManager.LoadScene("StartScene");
        }
    }

    public void DecreaseHp()
    {
        this.HpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
