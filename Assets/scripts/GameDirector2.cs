using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector2 : MonoBehaviour
{
    public static int mode = 1;
    public GameObject hardPanel;
    public GameObject easyPanel;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void GameStartButton()
    {
            SceneManager.LoadScene("GameScene");
    }
    public void EasyButtonEvent()
    {
        mode = 1;
        hardPanel.SetActive(true);
        easyPanel.SetActive(false);
    }
    public void HardButtonEvent()
    {
        mode = 2;
        easyPanel.SetActive(true);
        hardPanel.SetActive(false);
    }
}
