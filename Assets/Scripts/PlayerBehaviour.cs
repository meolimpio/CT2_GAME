using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimentação horizontal
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontal * speed, rb.velocity.y);
        rb.velocity = movement;

        // Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

}
