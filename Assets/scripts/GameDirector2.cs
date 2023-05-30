using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector2 : MonoBehaviour
{
    public Text text;
    public Text text2;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        text.text ="GamePro001";
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("GameScene");
        }
        text2.text = "GameStart!";
    }
}
