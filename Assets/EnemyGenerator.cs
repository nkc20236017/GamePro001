using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float span = 1.0f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta>this.span)
        {
            this.delta = 0;
            GameObject go=Instantiate(EnemyPrefab);
            int px = Random.Range(-4,5);
            go.transform.position=new Vector3(11,px,0);
        }
    }
}
