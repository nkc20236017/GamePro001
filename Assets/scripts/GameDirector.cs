using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject HpGauge;
    public GameObject panel;
    public bool Judge=true;
    void Start()
    {
        this.HpGauge = GameObject.Find("HpGauge");
    }
    void Update()
    {
        this.HpGauge.GetComponent<Image>().fillAmount -= 0.0001f;
        if (this.HpGauge.GetComponent<Image>().fillAmount<=0)
        {
            panel.SetActive(true);
            Judge = false;
            if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("StartScene");
            }
        }
    }

    public void DecreaseHp()
    {
        this.HpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void DecreaseHp2()
    {
        this.HpGauge.GetComponent<Image>().fillAmount += 0.05f;
    }
}
