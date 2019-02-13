using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorKiller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "laser" )
        {
            // increase score - included in WordDisplay.RemoveWord();
        }
        else if (collision.gameObject.tag == "castle")
        {
            // destroy castle
        }
        else if (collision.gameObject.tag == "gun")
        {
            // game over
        }
        // destroy meteor

    }
}
