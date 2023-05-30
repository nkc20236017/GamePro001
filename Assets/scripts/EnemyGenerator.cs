using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    GameObject director;
    float span = 1.0f;
    float delta = 0;

    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }
    void Update()
    {
        if (director.GetComponent<GameDirector>().Judge)
        {
            if (span > 0.3f)
            {
                span -= 0.0001f;
            }
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(EnemyPrefab);
                int px = Random.Range(-4, 5);
                go.transform.position = new Vector3(11, px, 0);
            }
        }
    }
}
