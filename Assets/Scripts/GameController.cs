using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;
using UnityEngine.UI; 

public class GameController : MonoBehaviour
{
    
    public static GameController gc;
    public int coins;
    public TextMeshProUGUI textScore;

    void Awake()
    {
        if (gc == null)
        {
           gc = this; 
        }

        else if (gc != this)
        {
            Destroy(gameObject);
        }
    }
}
