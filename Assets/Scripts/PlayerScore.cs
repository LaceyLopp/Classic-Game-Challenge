using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerScore : MonoBehaviour
{

    public static PlayerScore instance;


    public TextMeshProUGUI scoreText;
    public int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 10;
        scoreText.text = "Score: " + score.ToString();
    }
}
