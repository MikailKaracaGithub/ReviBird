using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{

    public float velocity = 1;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 means left click
        {
            //jump
            rb.velocity = Vector2.up * velocity;

        }
    }
}
