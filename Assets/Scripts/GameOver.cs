using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameOver : MonoBehaviour
{

    public static bool isPlayerDead = false;
    public TextMeshProUGUI gameOverText;

    void Start()
    {
        gameOverText.enabled = false;
    }

    void Update()
    {
        if (isPlayerDead)
        {
            Time.timeScale = 0;
            gameOverText.enabled = true;
        }
    }
}
