using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShotController : MonoBehaviour
{

    void Update()
    {
        transform.Translate(0, 0.1f, 0);
        if (transform.position.x > 11)
        {
            Destroy(gameObject);
        }
    }
}
