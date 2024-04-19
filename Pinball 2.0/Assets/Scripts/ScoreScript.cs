using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public TextMeshProUGUI scoreText; // Texto para exibir o score
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScore();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("MiniBumper"))
        {
            score += 200; // Adiciona 200 pontos ao colidir com um minibumper
            UpdateScoreText();
        }
        else if(collision.gameObject.CompareTag("Bumper"))
        {
            score += 100; // Adiciona 100 pontos ao colidir com um bumper
            UpdateScoreText();
        }
        else if(collision.gameObject.CompareTag("Flipper"))
        {
            score += 500; // Adiciona 500 pontos ao colidir com um flipper
            UpdateScoreText();
        } 
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }
}
