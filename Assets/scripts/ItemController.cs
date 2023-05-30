using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    GameObject director;
    GameObject player;
    public GameObject itemcatch;
    void Start()
    {
        this.player = GameObject.Find("MyChar");
        this.director = GameObject.Find("GameDirector");
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
        if (other.gameObject.tag == "MyChar")
        {
            Instantiate(itemcatch.gameObject, player.transform.position, this.transform.rotation);
            director.GetComponent<GameDirector>().DecreaseHp2();
            Destroy(gameObject);
        }
    }
}
