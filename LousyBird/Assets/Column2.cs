using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<burd2>() != null)
        {
            GameControl2.instance.BirdScored();
        }
    }
}