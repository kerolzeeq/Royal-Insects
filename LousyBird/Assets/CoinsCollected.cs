using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCollected : MonoBehaviour
{
    public Text CollectedCoinText;
    int coinscollected = 0;
    

    // Update is called once per frame
    void Update()
    {
        coinscollected = PlayerPrefs.GetInt("coinscollected");
        CollectedCoinText.text = "  " + coinscollected;
    }
}
