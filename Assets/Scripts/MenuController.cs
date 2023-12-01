using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    //Carregar a cena de jogo 
    public void LoadScene(string cena)
    {
        SceneManager.LoadScene(cena);
    }
}
