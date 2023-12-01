using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    int numberOfJumps = 2;

    [SerializeField ]private float jumpForce = 5.0f;
    
    bool isJumping;

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

        //Ativação do pulo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isJumping == true && numberOfJumps > 0)
            {
                Jump();
            }
        }
    }

    //Pulo
    void Jump()
    {
        numberOfJumps = numberOfJumps - 1;
        rb.velocity = new Vector2 (0, jumpForce);
    }

    //Colisão com as moedas
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coin")
        {
            Destroy(col.gameObject);
            gcPlayer.coins++;
            gcPlayer.textScore.text = gcPlayer.coins.ToString();
        }
    }

    //Verifica o Chão
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground")
        {
            numberOfJumps = 2;
            isJumping = true;
        }
    }
}
