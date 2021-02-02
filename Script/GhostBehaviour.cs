using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBehaviour : MonoBehaviour
{
    Rigidbody2D rb;

    float initialPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPos = transform.position.x;
    }

    void Update()
    {
        rb.velocity = transform.right * 0.1f;

        if (transform.position.x > initialPos + 0.25f)
        {
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        if (transform.position.x < initialPos - 0.25f)
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }

}
