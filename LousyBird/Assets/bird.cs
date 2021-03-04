using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float upforce = 200f;
    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;
    public GameObject pauseMenuUI;
    int deadcheck = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0) && pauseMenuUI.activeSelf == false)
            {
        
                    
                    rb2d.velocity = Vector2.zero;
                    rb2d.AddForce(new Vector2(0, upforce));
                    anim.SetTrigger("Flap");
                    FindObjectOfType<AudioManager>().Play("BugFlap");
                


            }
        }
    }
    void OnCollisionEnter2D()
    {
        rb2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        GameControl.instance.BirdDied();
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Ceiling"))
        {

            rb2d.AddForce(new Vector2(0, -upforce));
        }
        
    }
}
