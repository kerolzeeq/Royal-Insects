using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingobject2 : MonoBehaviour
{
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(GameControl2.instance.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl2.instance.gameOver == true)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}