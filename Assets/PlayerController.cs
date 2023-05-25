using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -8.5f)//ç∂
        {
            transform.Translate(0,-0.2f,0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 8.5f)//âE
        {
            transform.Translate(0,0.2f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 4.5f)//è„
        {
            transform.Translate(-0.2f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4.5f)//â∫
        {
            transform.Translate(0.2f, 0, 0);
        }
    }
}
