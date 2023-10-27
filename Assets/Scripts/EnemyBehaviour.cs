using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed;
    public float distance;

    bool isRight = true;

    public Transform groundCheck;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D ground = Physics2D.Raycast(groundCheck.position, Vector2.down, distance);

        if (ground.collider == false)
        {
            if (isRight == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isRight = false;
            }

            else
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                isRight = true;
            }
        }
    }
}
