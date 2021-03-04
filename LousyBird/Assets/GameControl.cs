using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using GoogleMobileAds.Api;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public Text highscoreText;
    public Text scoreText;
    public Text CoinText;
    public Text CollectedCoinText;
    private int score = 0, highscore = 0;
    int coinsekarang = 0, coinscollected = 0;
    public GameObject showcoin;
    int nombo = 0;
    
    string App_ID = "ca-app-pub-4627752378260475~2566942727";
    string Interstitial_AD_ID = "ca-app-pub-4627752378260475/5991838955";
    private InterstitialAd interstitial;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance != this)
        {
            Destroy(gameObject);
        }

        MobileAds.Initialize(App_ID);
        RequestInterstitial();
        

    }

    /// <summary>
    public void RequestInterstitial()
    {

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(Interstitial_AD_ID);

        // Called when an ad request has successfully loaded.
        this.interstitial.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is shown.
        this.interstitial.OnAdOpening += HandleOnAdOpened;
        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        this.interstitial.OnAdLeavingApplication += HandleOnAdLeavingApplication;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    public void ShowInterstitialAd()
    {


        if (GameControl.instance.gameOver == true)
        {
            if (this.interstitial.IsLoaded())
            {
                this.interstitial.Show();
               
            }
        }



    }



    //////////////////////////////////
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
       
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }
    /// </summary>

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        highscore = PlayerPrefs.GetInt("highscore");
        highscoreText.text = "HighScore: " + highscore.ToString();
        coinsekarang = PlayerPrefs.GetInt("coinsekarang");
        CoinText.text = " x" + coinsekarang.ToString();
        coinscollected = PlayerPrefs.GetInt("coinscollected");
        CollectedCoinText.text = "   " + coinscollected;

    }
    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }

       

        score++;
        scoreText.text = "Score: " + score.ToString();

        if (score > highscore)
            PlayerPrefs.SetInt("highscore", score);

    }

    public void BirdDied()
    {
        
        showcoin.SetActive(true);
        gameOverText.SetActive(true);
        gameOver = true;

        nombo= PlayerPrefs.GetInt("nombo");
        nombo++;
        PlayerPrefs.SetInt("nombo", nombo);
        if (nombo == 5)
        {
            ShowInterstitialAd();
            PlayerPrefs.SetInt("nombo", 0);
        }
    }
}
