using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorKiller : MonoBehaviour
{
    public WordDisplay WordDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnCollisionEnter2D(Collision2D objectYouCollidedWith) { your_code}

    //void onCollisionEnter2D(Collision2D gameObject.tag == "castle")
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "laser" )
        {
            WordDisplay.RemoveWord();
        }
        if (collision.gameObject.tag == "castle")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "gun")
        {
            // game over
        }
        // destroy meteor

    }
}
