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
        int Key_x = 0;
        int Key_y = 0;

        Animation animator = GetComponent<Animation>();
        int trans = animator.GetInteger("trans");

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -8.5f)//ç∂
        {
            Key_y = -1;
            trans--;
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 8.5f)//âE
        {
            Key_y = 1;
            trans++;
        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 4.5f)//è„
        {
            Key_x = -1;
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4.5f)//â∫
        {
            Key_x = 1;
        }

        Vector2 dir;
        dir.x= Key_x * 0.2f;
        dir.y =  Key_y * 0.2f;
        transform.Translate(dir);
        animator.SetInteger("trans",trans);
    }
}
