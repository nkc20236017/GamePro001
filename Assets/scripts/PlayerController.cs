using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float x;
    float y;
    GameObject director;

    void Start()
    {
        Application.targetFrameRate = 60;
        this.director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        Animator animator = GetComponent<Animator>();
        int Key_x = 0;
        int Key_y = 0;
        int judge = animator.GetInteger("Judge");
        judge = 0;
        if (director.GetComponent<GameDirector>().Judge)
        {
            x = Input.GetAxisRaw("Horizontal");
            y = Input.GetAxisRaw("Vertical");
        }
        if (x < 0 && transform.position.x > -8.5f)//¶
        {
            Key_y = -1;
                    }
        if (x > 0 && transform.position.x < 8.5f)//‰E
        {
            Key_y = 1;
                    }
        if (y > 0 && transform.position.y < 4.5f)//ã
        {
            Key_x = -1;
            judge=1;
        }
        else if (y < 0 && transform.position.y > -4.5f)//‰º
        {
            Key_x = 1;
            judge=-1;
        }
        
        Vector2 dir;
        dir.x= Key_x;
        dir.y =  Key_y;
        dir=dir.normalized *  0.2f;
        transform.Translate(dir);
        animator.SetInteger("Judge",judge);
    }
}
