using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosEnemyController : MonoBehaviour
{
    int bosHP=20;
    public GameObject bosenemyDeath;
    GameObject director;
    GameObject bosHPGauge;
    Rigidbody2D rigid2D;
    bool bosposi = true;
    int a = 0, b = 0;
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
        this.bosHPGauge = GameObject.Find("BosHPGauge");
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.x>=4&&bosposi)
        {
            transform.Translate(-0.05f, 0, 0);
        }
        else
        {
            bosposi = false;
            if (b == 0)
            {
                transform.Translate(-0.1f, 0, 0);
            }
            else if (b == 1)
            {
                transform.Translate(-0.2f, 0, 0);
            }
            else if (b == 2)
            {
                transform.Translate(-0.05f, 0, 0);
            }
        }
        if (transform.position.x < -11&&bosposi==false)
        {
            a = Random.Range(-4, 5);
            if (GameDirector2.mode == 2)
            {
                b = Random.Range(0, 3);
            }
            else
            {
                b = 2;
            }
            
            transform.position = new Vector3(11, a, 0);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "MyChar")
        {
            director.GetComponent<GameDirector>().DecreaseHp();
        }
        if (other.gameObject.tag == "MyShot")
        {
                Destroy(other.gameObject);
            bosHP--;
            director.GetComponent<GameDirector>().DecreaseHpBos();
            if (bosHP<=0)
            {
                Instantiate(bosenemyDeath.gameObject, this.transform.position, this.transform.rotation);
                Destroy(gameObject);
                bosHPGauge.SetActive(false);
                director.GetComponent<ScoreController>().AddPoint2();
            }
        }
    }
}
