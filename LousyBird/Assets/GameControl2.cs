using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl2 : MonoBehaviour
{
    public static GameControl2 instance;
    public GameObject P1win;
    public GameObject P2win;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public Text highscoreText;
    public Text scoreText;
    private int score = 0, highscore2 = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        highscore2 = PlayerPrefs.GetInt("highscore2");
        highscoreText.text = "HighScore: " + highscore2.ToString();
    }
    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }



        score++;
        scoreText.text = "Score: " + score.ToString();

        if (score > highscore2)
            PlayerPrefs.SetInt("highscore2", score);

    }

    public void BirdDied()
    {
        gameOver = true;
    }
    public void Player1Wins()
    {
        if (P2win.activeInHierarchy == true)
        {

        }
        else
        {
            P1win.SetActive(true);
        }
        
    }

    public void Player2Wins()
    {
        if (P1win.activeInHierarchy == true)
        {

        }
        else
        {
            P2win.SetActive(true);
        }
    }
}
