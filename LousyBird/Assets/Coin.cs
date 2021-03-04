using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public GameObject ac;
    int coinscollected = 0, coinsekarang = 0;
    // Start is called before the first frame update
    void Start()
    {
        ac.SetActive(true);
        PlayerPrefs.SetInt("coinsekarang", 0);
        coinsekarang = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coinsekarang = PlayerPrefs.GetInt("coinsekarang");

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<bird>() != null)
        {
            FindObjectOfType<AudioManager>().Play("CoinPickup");
            coinsekarang = coinsekarang + 10;
            PlayerPrefs.SetInt("coinsekarang", coinsekarang);
            coinscollected = PlayerPrefs.GetInt("coinscollected");

            coinscollected = coinscollected + 10;   
            PlayerPrefs.SetInt("coinscollected", coinscollected);
            ac.SetActive(false);
        }
    }
}
