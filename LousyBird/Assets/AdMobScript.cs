using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using GoogleMobileAds.Api;
using System.Globalization;

public class AdMobScript : MonoBehaviour
{
    public static AdMobScript instance;
    public Text adStatus;
    string App_ID = "ca-app-pub-4627752378260475~2380308724";
    string Interstitial_AD_ID = "ca-app-pub-3940256099942544/1033173712";
    int nombo=0;

    private InterstitialAd interstitial;
    // Start is called before the first frame update

    void Start()
    {
        
        MobileAds.Initialize(App_ID);
        RequestInterstitial();
    }

    void Update()
    {
        if (GameControl.instance.gameOver == true)
        {
            ShowInterstitialAd();
        }
    }

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
        nombo++;
        if (nombo/10 == 1)
        {
            if (GameControl.instance.gameOver == true)
            {
                if (this.interstitial.IsLoaded())
                {
                    this.interstitial.Show();
                    nombo = 0;
                }
            }
        }
        
        
    }



    //////////////////////////////////
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        adStatus.text = "Ad Loaded";
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        adStatus.text = "Ad Failed to Load";
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

}
