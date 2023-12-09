using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    [SerializeField] int numLives = 3;
    [SerializeField] int numOfHearts;
    public Image[] hearts;

    void Update()
    {
        for(int contador = 0; contador < hearts.Length; contador++)
        {
            if(contador < numLives){
                hearts[contador].enabled = true;
            }
            else
            {
                hearts[contador].enabled = false;
            }
        }
    }

    //Colisão com o inimigo
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            LoseLife();
        }
    }

    //Perda de vida quando colide com o inimigo
    public void LoseLife()
    {
        numLives--;

        if (numLives <= 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("Victory");
        }

        else
        {
            Debug.Log("Continue");
        }
    }
}
