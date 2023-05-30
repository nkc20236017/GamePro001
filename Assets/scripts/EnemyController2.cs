using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController2 : MonoBehaviour
{
    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        if (transform.position.x < -11)
        {
            Destroy(gameObject);

        }
    }
}
