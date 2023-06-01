using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public GameObject panel;
    public GameObject bosHPGauge;
    public Slider slider;
    public Slider slider2;
    public bool Judge=true;
    void Start()
    {
        slider.value = 1;
    }
    void Update()
    {
        if (this.slider.value <= 0.1f)
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
        this.slider.value -= 0.2f;
    }
    public void DecreaseHp2()
    {
        this.slider.value += 0.1f;
    }
    public void DecreaseHpBos()
    {
        this.slider2.value -= 0.1f;
    }
    public void BosEvent()
    {
        bosHPGauge.SetActive(true);
        this.slider2.value = 2;
    }
}
