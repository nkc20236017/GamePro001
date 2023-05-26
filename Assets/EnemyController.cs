using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject director;
    Rigidbody2D rigid2D;
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

        void Update()
        {
        transform.Translate(-0.1f, 0, 0);
        if (transform.position.x<-11)
        {
            Destroy(gameObject);

        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag=="MyChar")
            {
                director.GetComponent<GameDirector>().DecreaseHp();
                Destroy(gameObject);
            }
            if (other.gameObject.tag=="MyShot")
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}
