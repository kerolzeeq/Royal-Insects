using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Buying : MonoBehaviour
{

    int checkeq;
    int tengahpakai;
    int coinscollected;
    int beli1=0, beli2=0, beli3=0, beli4=0, beli5=0, beli6=0, beli7=0;

    public GameObject NotEnufPanel;
    public GameObject HornedBeeCheck,PrincessRed,DukeEggfly,JesterB,Archer,Queenant,KingB;

    public GameObject BUYHornedBeeCheck, BUYPrincessRed, BUYDukeEggfly, BUYJesterB, BUYArcher, BUYQueenant, BUYKingB;
    // Start is called before the first frame update
    void Start()
    {
        //CHECK BELI KE TAK!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        beli1 = PlayerPrefs.GetInt("beli1");
        beli2 = PlayerPrefs.GetInt("beli2");
        beli3 = PlayerPrefs.GetInt("beli3");
        beli4 = PlayerPrefs.GetInt("beli4");
        beli5 = PlayerPrefs.GetInt("beli5");
        beli6 = PlayerPrefs.GetInt("beli6");
        beli7 = PlayerPrefs.GetInt("beli7");

        

        if (beli1 == 1)
        {
            BUYHornedBeeCheck.SetActive(false);
        }
        if (beli2 == 1)
        {
            BUYPrincessRed.SetActive(false);
        }
        if (beli3 == 1)
        {
            BUYDukeEggfly.SetActive(false);
        }
        if (beli4 == 1)
        {
            BUYJesterB.SetActive(false);
        }
        if (beli5 == 1)
        {
            BUYArcher.SetActive(false);
        }
        if (beli6 == 1)
        {
            BUYQueenant.SetActive(false);
        }
        if (beli7 == 1)
        {
            BUYKingB.SetActive(false);
        }
        //
        coinscollected = PlayerPrefs.GetInt("coinscollected");
        
        tengahpakai = PlayerPrefs.GetInt("tengahpakai");
        PlayerPrefs.SetInt("tengahpakai", tengahpakai);
    }

    // Update is called once per frame
    void Update()
    {
        coinscollected = PlayerPrefs.GetInt("coinscollected");
        //CHECK UNEQUIP ACTIVE KE TAK
        checkeq = PlayerPrefs.GetInt("checkeq");
        if (checkeq == 1)
        {
            HornedBeeCheck.SetActive(true);
            PrincessRed.SetActive(false);
            DukeEggfly.SetActive(false);
            JesterB.SetActive(false);
            Archer.SetActive(false);
            Queenant.SetActive(false);
            KingB.SetActive(false);
        }
        if (checkeq == 2)
        {
            HornedBeeCheck.SetActive(false);
            PrincessRed.SetActive(true);
            DukeEggfly.SetActive(false);
            JesterB.SetActive(false);
            Archer.SetActive(false);
            Queenant.SetActive(false);
            KingB.SetActive(false);
        }
        if (checkeq == 3)
        {
            HornedBeeCheck.SetActive(false);
            PrincessRed.SetActive(false);
            DukeEggfly.SetActive(true);
            JesterB.SetActive(false);
            Archer.SetActive(false);
            Queenant.SetActive(false);
            KingB.SetActive(false);
        }
        if (checkeq == 4)
        {
            HornedBeeCheck.SetActive(false);
            PrincessRed.SetActive(false);
            DukeEggfly.SetActive(false);
            JesterB.SetActive(true);
            Archer.SetActive(false);
            Queenant.SetActive(false);
            KingB.SetActive(false);
        }
        if (checkeq == 5)
        {
            HornedBeeCheck.SetActive(false);
            PrincessRed.SetActive(false);
            DukeEggfly.SetActive(false);
            JesterB.SetActive(false);
            Archer.SetActive(true);
            Queenant.SetActive(false);
            KingB.SetActive(false);
        }
        if (checkeq == 6)
        {
            HornedBeeCheck.SetActive(false);
            PrincessRed.SetActive(false);
            DukeEggfly.SetActive(false);
            JesterB.SetActive(false);
            Archer.SetActive(false);
            Queenant.SetActive(true);
            KingB.SetActive(false);
        }
        if (checkeq == 7)
        {
            HornedBeeCheck.SetActive(false);
            PrincessRed.SetActive(false);
            DukeEggfly.SetActive(false);
            JesterB.SetActive(false);
            Archer.SetActive(false);
            Queenant.SetActive(false);
            KingB.SetActive(true);
        }
        //CHECK ENEQUIP
    }

    public void HornedBee()
    {
        tengahpakai = 1;
        PlayerPrefs.SetInt("tengahpakai", tengahpakai);
        checkeq = 1;
        PlayerPrefs.SetInt("checkeq", checkeq);
    }
    public void RedPrincess()
    {
        tengahpakai = 2;
        PlayerPrefs.SetInt("tengahpakai", tengahpakai);
        checkeq = 2;
        PlayerPrefs.SetInt("checkeq", checkeq);
    }
    public void DukeEgg()
    {
        tengahpakai = 3;
        PlayerPrefs.SetInt("tengahpakai", tengahpakai);
        checkeq = 3;
        PlayerPrefs.SetInt("checkeq", checkeq);
    }
    public void JesterBee()
    {
        tengahpakai = 4;
        PlayerPrefs.SetInt("tengahpakai", tengahpakai);
        checkeq = 4;
        PlayerPrefs.SetInt("checkeq", checkeq);
    }
    public void ArcherBee()
    {
        tengahpakai = 5;
        PlayerPrefs.SetInt("tengahpakai", tengahpakai);
        checkeq = 5;
        PlayerPrefs.SetInt("checkeq", checkeq);
    }
    public void QueenAnt()
    {
        tengahpakai = 6;
        PlayerPrefs.SetInt("tengahpakai", tengahpakai);
        checkeq = 6;
        PlayerPrefs.SetInt("checkeq", checkeq);
    }
    public void KingBee()
    {
        tengahpakai = 7;
        PlayerPrefs.SetInt("tengahpakai", tengahpakai);
        checkeq = 7;
        PlayerPrefs.SetInt("checkeq", checkeq);
    }

    public void Unequip()
    {
        tengahpakai = 0;
        PlayerPrefs.SetInt("tengahpakai", tengahpakai);
        checkeq = 0;
        PlayerPrefs.SetInt("checkeq", checkeq);
    }
/////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </BUYPART>
    public void BuyHornedBee()
    {
        if (coinscollected < 250)
        {
            NotEnufPanel.SetActive(true);
        }
        else
        {
            coinscollected = coinscollected - 250;
            PlayerPrefs.SetInt("coinscollected", coinscollected);
            PlayerPrefs.SetInt("beli1", 1);
            BUYHornedBeeCheck.SetActive(false);
        }
    }
    public void BuyRedPrincess()
    {
        if (coinscollected < 500)
        {
            NotEnufPanel.SetActive(true);
        }
        else
        {
            coinscollected = coinscollected - 500;
            PlayerPrefs.SetInt("coinscollected", coinscollected);
            PlayerPrefs.SetInt("beli2", 1);
            BUYPrincessRed.SetActive(false);
        }
    }
    public void BuyDukeEgg()
    {
        if (coinscollected < 800)
        {
            NotEnufPanel.SetActive(true);
        }
        else
        {
            coinscollected = coinscollected - 800;
            PlayerPrefs.SetInt("coinscollected", coinscollected);
            PlayerPrefs.SetInt("beli3", 1);
            BUYDukeEggfly.SetActive(false);
        }
    }
    public void BuyJesterBee()
    {
        if (coinscollected < 1000)
        {
            NotEnufPanel.SetActive(true);
        }
        else
        {
            coinscollected = coinscollected - 1000;
            PlayerPrefs.SetInt("coinscollected", coinscollected);
            PlayerPrefs.SetInt("beli4", 1);
            BUYJesterB.SetActive(false);
        }
    }
    public void BuyArcherBee()
    {
        if (coinscollected < 2500)
        {
            NotEnufPanel.SetActive(true);
        }
        else
        {
            coinscollected = coinscollected - 2500;
            PlayerPrefs.SetInt("coinscollected", coinscollected);
            PlayerPrefs.SetInt("beli5", 1);
            BUYArcher.SetActive(false);
        }
    }
    public void BuyQueenAnt()
    {
        if (coinscollected < 5000)
        {
            NotEnufPanel.SetActive(true);
        }
        else
        {
            coinscollected = coinscollected - 5000;
            PlayerPrefs.SetInt("coinscollected", coinscollected);
            PlayerPrefs.SetInt("beli6", 1);
            BUYQueenant.SetActive(false);
        }
    }
    public void BuyKingBee()
    {
        if (coinscollected < 10000)
        {
            NotEnufPanel.SetActive(true);
        }
        else
        {
            coinscollected = coinscollected - 10000;
            PlayerPrefs.SetInt("coinscollected", coinscollected);
            PlayerPrefs.SetInt("beli7", 1);
            BUYKingB.SetActive(false);
        }
    }
}
