using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose : MonoBehaviour
{
    public GameObject[] insects;
    int index = 0,tengahpakai;
    // Start is called before the first frame update
    void Start()
    {
        insects[0].SetActive(false);
        insects[1].SetActive(false);
        insects[2].SetActive(false);
        insects[3].SetActive(false);
        insects[4].SetActive(false);
        insects[5].SetActive(false);
        insects[6].SetActive(false);
        insects[7].SetActive(false);

        tengahpakai = PlayerPrefs.GetInt("tengahpakai");
        insects[tengahpakai].SetActive(true);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
