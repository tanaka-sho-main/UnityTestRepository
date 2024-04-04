using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.InputSystem.Controls;

public class UIController : MonoBehaviour
{
    int score = 0;
    GameObject scoreText;
    GameObject gameOverText;
    GameObject titleButton;


    public void GameOver()
    {
        this.gameOverText.GetComponent<TextMeshProUGUI>().text = "GameOver";
        this.titleButton.SetActive(true);
    }
    public void AddScore()
    {
        this.score += 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
        this.titleButton = GameObject.Find("Button");
        this.titleButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score:" + score.ToString("D4");
    }
}
