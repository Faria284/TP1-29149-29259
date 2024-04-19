using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResetScript : MonoBehaviour
{
    public string inputName;

    public TextMeshProUGUI gameOverText;

    public GameObject gameOverPanel;

    public TextMeshProUGUI restartText;

    private Vector3 initialPosition = new Vector3(3.109f, 0.13f, 1.2f);

    private int score;

    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        gameOverText.text = null;
        restartText.text = null;
        gameOverPanel.SetActive(false);
    }

    
    void Update()
    {
        if(gameOverText != null && gameOverPanel != null && restartText != null)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                transform.position = initialPosition;
                score = 0;
                UpdateScoreText();
                gameOverText.text = null;
                restartText.text = null;
                gameOverPanel.SetActive(false);
            } 
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                QuitGame();
            }
        }
        
    }

    void QuitGame()
    {
        Application.Quit();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ResetBound"))
        {
            gameOverText.text = "Game Over";
            restartText.text = "Press <R> to restart the game";
            gameOverPanel.SetActive(true);
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
