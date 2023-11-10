using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    public float jumpForce;

    private GameController gcPlayer;

    void Start()
    {
        gcPlayer = GameController.gc;
        gcPlayer.coins = 0;

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimentação 
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontal * speed, rb.velocity.y);
        rb.velocity = movement;

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coin")
        {
            Destroy(col.gameObject);
            gcPlayer.coins++;
            gcPlayer.textScore.text = gcPlayer.coins.ToString();
        }
    }
}
