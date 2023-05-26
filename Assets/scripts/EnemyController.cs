using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemyDeath;
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
        if (transform.position.x < -11)
        {
            Destroy(gameObject);

        }
    }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag=="MyChar")
            {
                Instantiate(enemyDeath.gameObject,this.transform.position,this.transform.rotation);
                director.GetComponent<GameDirector>().DecreaseHp();
                Destroy(gameObject);
            }
            if (other.gameObject.tag=="MyShot")
            {
            Instantiate(enemyDeath.gameObject, this.transform.position, this.transform.rotation);
            Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
}
