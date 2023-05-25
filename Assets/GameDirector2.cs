using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector2 : MonoBehaviour
{
    GameObject Text;

    void Start()
    {
        this.Text = GameObject.Find("Text");
    }

    void Update()
    {
        this.Text.GetComponent<TextMeshProUGUI>().text =
            "    GamePro001\nMouseButton0 Start";
            if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
