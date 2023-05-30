using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShotGenerator : MonoBehaviour
{
    public GameObject MyShotPrefab;
    GameObject director;
    GameObject player;
    float span = 0.5f;
    float delta = 0.5f;

    void Start()
    {
        this.player = GameObject.Find("MyChar");
        this.director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        if (director.GetComponent<GameDirector>().Judge)
        {
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    this.delta = 0;
                    GameObject go = Instantiate(MyShotPrefab);
                    go.transform.position = new Vector3(player.transform.position.x + 1, player.transform.position.y, 0);
                }
            }
        }
    }
}
