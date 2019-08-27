using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    public GameManager gameManager;

    public float velocity = 1;
    private Rigidbody2D rb;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 means left click
        {
            //jump
            rb.velocity = Vector2.up * velocity;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
        audioSource.Play();
    }
}
